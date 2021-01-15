using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharedApi.Services;

namespace SharedApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharedApiController : ControllerBase
    {
        private readonly ILogger<SharedApiController> _logger;
        private readonly SomeSharedService _someSharedService;

        public SharedApiController(SomeSharedService someSharedService,
            ILogger<SharedApiController> logger)
        {
            _logger = logger;
            _someSharedService = someSharedService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        { 
            return Ok(_someSharedService.GetData());
        }
    }
}
