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
    [Route("api/[controller]")]
    public class ThingController : ControllerBase
    {
        private readonly ILogger<ThingController> _logger;

        private static readonly string[] LocalThingsCache = new[]
        {
           "Thing 1", 
           "Thing 2",
           "Thing 3",
           "Thing 4",
           "Thing 5",
           "Thing 6",
           "Thing 7",
           "Thing 8",
           "Thing 9",
           "Thing 10"
        };

        public ThingController(ILogger<ThingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return LocalThingsCache.AsEnumerable();
        }

        [HttpGet("{id?}")]
        public string Get(string id)
        {
            return LocalThingsCache.FirstOrDefault(s => s.EndsWith(id));
        }

    }
}