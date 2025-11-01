
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyRestApiServer.Data;

namespace MyRestApiServer.Controllers;

[ApiController]
[Route("apiController")]
public class WrestlingRosterController : ControllerBase
{

    [HttpGet]
    public IActionResult GetWrestlingFederationName() => Ok(new { message = "My wrestling Federation Name" });

    [HttpGet("wrestlers")]
    public IActionResult GetAllWrestler()
    {
        var wrestlers = FakeFederationWrestlerRepository.GetAllWrestlers();
        return wrestlers?.Count() > 0 ? Ok(wrestlers) : NotFound();
    }
}