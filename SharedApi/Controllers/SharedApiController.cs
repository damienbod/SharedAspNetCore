using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharedApiController : ControllerBase
    {
        private readonly ILogger<SharedApiController> _logger;

        public SharedApiController(ILogger<SharedApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        { 
            return Ok(new List<string> { "data from shared api", "more data" });
        }
    }
}
