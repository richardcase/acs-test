using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AcsTest.WebAPI.Controllers
{
    [Route("health")]
    public class HealthController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            //TODO: if shutting down return 500
            return StatusCode(200);
        }
    }
}
