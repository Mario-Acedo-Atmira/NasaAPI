using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NasaAPI.Controllers;
using NasaAPI.DataAccess;
using NasaAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NasaAPI.UnitTest
{
    public class UnitTest1
    {
        private readonly ModelController _model;
        private readonly Mock<API> _apimock=new Mock<API>();
        
        public UnitTest1()
        {
            _model = new ModelController(_apimock.Object);
        }
        
        
        [Fact]
        public async Task CasoValido()
        {

            int dia = 4;
            var customer = (OkObjectResult)await _model.GetTop3(dia);
            var ok= (OkObjectResult)await _model.GetTop3(dia);

            Assert.Equal(customer.ToString(), ok.ToString());
        }

        [Fact]
        public async Task CasoNoValido()
        {

            int dia = 8;
            var customer = (BadRequestResult)await _model.GetTop3(dia);
            var bad = (BadRequestResult)await _model.GetTop3(dia);

            Assert.Equal(customer.ToString(), bad.ToString());
        }

        [Fact]
        public async Task CasoVacio()
        {

            int dia = 1;
            var customer = (OkObjectResult)await _model.GetTop3(dia);
            var ok = (OkObjectResult)await _model.GetTop3(dia);

            Assert.Equal(customer.ToString(), ok.ToString());
        }
    }
}