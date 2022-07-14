using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NasaAPI.Controllers;
using NasaAPI.DataAccess;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NasaAPI.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task CasoValido()
        {

            //Arrange
            var model = new API();
            var controller = new ModelController(model);

            //Act
            var actionResult = (OkObjectResult)await controller.GetTop3(6);

            //Assert
            actionResult.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task CasoNoValido()
        {

            //Arrange
            var model = new API();
            var controller = new ModelController(model);

            //Act
            var actionResult = (BadRequestResult)await controller.GetTop3(8);

            //Assert
            actionResult.StatusCode.Should().Be(400);
        }

        [Fact]
        public async Task CasoVacio()
        {

            //Arrange
            var model = new API();
            var controller = new ModelController(model);

            //Act
            var actionResult = (OkObjectResult)await controller.GetTop3(1);

            //Assert
            actionResult.StatusCode.Should().Be(200);
        }
    }
}
