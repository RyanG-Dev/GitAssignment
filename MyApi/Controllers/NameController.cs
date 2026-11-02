using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { name = "Ryan Griffin" });
    }
}