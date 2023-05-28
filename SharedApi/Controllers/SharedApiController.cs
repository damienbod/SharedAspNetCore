using Microsoft.AspNetCore.Mvc;
using SharedApi.Services;

namespace SharedApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SharedApiController : ControllerBase
{
    private readonly SomeSharedService _someSharedService;

    public SharedApiController(SomeSharedService someSharedService)
    {
        _someSharedService = someSharedService;
    }

    [HttpGet]
    public ActionResult<string> Get()
    { 
        return Ok(_someSharedService.GetData());
    }
}
