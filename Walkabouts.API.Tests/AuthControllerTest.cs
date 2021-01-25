using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Walkabouts.API.Controllers;
using Walkabouts.Data.DTO;
using Walkabouts.Services.Interfaces;
using Xunit;

namespace Walkabouts.API.Tests
{
    public class AuthControllerTest
    {
        [Fact]
        public async void RegisterReturns_ServiceDTOResultAndRegisterDTOPayload()
        {
            //Arrange
            var mockAuthService = new Mock<IAuthService>();
            var modelTest = new RegisterDTO
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@dev.com",
                Password = "dev@1234"
            };

            mockAuthService.Setup(item => item.RegisterUser(modelTest))
                            .ReturnsAsync(new ServiceResultDTO { Success = true, Data = new RegisterDTO() { Id=1} });
            
            //Act
            var controller = new AuthController(mockAuthService.Object);
            var result = await controller.Register(modelTest);
            
            //Assert
            Assert.IsType<ServiceResultDTO>(result);
            var viewModel = (result as ServiceResultDTO).Data;
            Assert.IsType<RegisterDTO>(viewModel);
        }

        [Fact]
        public async void RegisterReturns_ServiceDTOWithBadRequest()
        {
            // Arrange
            var modelTest = new RegisterDTO() { FirstName="John", LastName="Doe"};
            var mockAuthService = new Mock<IAuthService>();
            mockAuthService.Setup(item => item.RegisterUser(modelTest))
                           .ReturnsAsync(new ServiceResultDTO { Success = true, Data = new RegisterDTO() { Id = 1 } });
            var controller = new AuthController(mockAuthService.Object);
            controller.ModelState.AddModelError("FirstName", "Required");
            controller.ModelState.AddModelError("LastName", "Required");
            controller.ModelState.AddModelError("Email", "Required");
            controller.ModelState.AddModelError("Password", "Required");


            // Act
            var result = await controller.Register(modelTest);
            //Assert
            Assert.IsType<ServiceResultDTO>(result);
            Assert.False(result.Success);

        }


    }
}
