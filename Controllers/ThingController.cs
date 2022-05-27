using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytescount.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bytescount.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ThingController : ControllerBase
    {
        private readonly ILogger<ThingController> _logger;

        public ThingController(ILogger<ThingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return  Ok();
        }
    }
}