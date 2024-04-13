using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Assignment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Subscribe()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Unsubscribe()
    {
        return Ok();
    }
}
