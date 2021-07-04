using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Walkabouts.Data.Domain;
using Walkabouts.Repository;
using Xunit;

namespace Walkabouts.API.Tests
{
    public class CatalogControllerTest
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IWalkaboutRepository<Product>> mockRepo = new Mock<IWalkaboutRepository<Product>>();
            //mockRepo.Setup(m => m.Get(x=> x)).Returns((new Product[] {
            //                new Product {ProductID = 1, Name = "P1"},
            //                new Product {ProductID = 2, Name = "P2"}
            //                }).AsQueryable<Product>());

        }
    }
    }
