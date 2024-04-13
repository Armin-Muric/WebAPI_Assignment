using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Assignment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }

}
