using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NasaAPI.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NasaAPI.Controllers
{
    [Route("asteroids")]
    [ApiController]
    public class AsteroidsController : ControllerBase
    {
        private readonly IMeteoritoService _model;

        public AsteroidsController(IMeteoritoService model)
        {
            _model = model;
        }

        [HttpGet]
        public async Task<IActionResult> GetTop3(int days)
        {

            if (days > 7 || days <= 0)
            {
                //Response.Headers.Add("Error", "El parametro days tiene que estar entre 1 y 7");
                return BadRequest();
            }
            else
            {
                var entity = _model.Obtenertop3(days);
                if (entity.Count == 0)
                {
                    //Response.Headers.Add("Error", "La lista de meteoritos está vacia");
                    return Ok(entity);
                }

                return Ok(entity);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveAsteroids(int days)
        {

            if (days > 7 || days <= 0)
            {
                //Response.Headers.Add("Error", "El parametro days tiene que estar entre 1 y 7");
                return BadRequest();
            }
            else
            {
                var entity = _model.Save3Meteoritos(days);
                if (entity.Count == 0)
                {
                    //Response.Headers.Add("Error", "La lista de meteoritos está vacia");
                    return Ok(entity);
                }

                return Ok(entity);
            }
        }

    }

    
}
