using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository;
using Walkabouts.Services.DTO;
using Walkabouts.Services.Implementations;
using Walkabouts.Services.Interfaces;
using Walkabouts.Services.Mapping;
using Walkabouts.WebASP.Controllers;
using Xunit;

namespace Walkabouts.API.Tests
{
    public class CatalogControllerTest
    {
        public CatalogControllerTest()
        {

        }

        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            //repo
            Mock<IWalkaboutRepository<Product>> mockRepo = new Mock<IWalkaboutRepository<Product>>();
            mockRepo.Setup(m => m.GetAll(1,10)).Returns((new Product[] {
                            new Product {Id = 1, ProductName = "Product1", UnitPrice=10.00m },
                            new Product {Id = 2, ProductName = "Product2"}
                            }).AsQueryable<Product>());

            //auto mapper configuration
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfilesMap());
            });
            var mapper = mockMapper.CreateMapper();
            
            //service
            CatalogService catalogService = new CatalogService(mockRepo.Object, mockMapper.CreateMapper());
            
            //controller
            CatalogController controller = new CatalogController(catalogService);

            // Act
            IEnumerable<CatalogItemDTO> result =  (controller.Index() as ViewResult).ViewData.Model  as IEnumerable<CatalogItemDTO>;

            // Assert
            CatalogItemDTO[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("Product1", prodArray[0].ProductName);
            Assert.Equal("Product2", prodArray[1].ProductName);

        }
    }
    }
