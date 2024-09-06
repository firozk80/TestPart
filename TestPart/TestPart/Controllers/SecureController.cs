using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SecureController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Value = "This is a protected resource." });
    }
}
