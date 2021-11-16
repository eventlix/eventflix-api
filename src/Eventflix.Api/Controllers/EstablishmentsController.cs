using Microsoft.AspNetCore.Mvc;

namespace Eventflix.Api.Controllers;

[ApiController]
[Route("establishments")]
public class EstablishmentsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
