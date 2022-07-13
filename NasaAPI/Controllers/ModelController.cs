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
    public class ModelController : ControllerBase
    {
        private readonly IAPI _model;

        public ModelController(IAPI model)
        {
            _model = model;
        }

        [HttpGet]
        public async Task<IActionResult> GetWhere(int days)
        {

            if (days > 7 || days <= 0)
            {
                return BadRequest();
            }
            else
            {
                var entity = _model.Obtenertop3(days);
                if (entity.Result.Count == 0)
                {
                    return Ok(entity);
                }

                return Ok(entity);
            }
        }

    }

    
}
