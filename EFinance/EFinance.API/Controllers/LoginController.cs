using Microsoft.AspNetCore.Mvc;

namespace EFinance.API.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Produces("application/json")]
    [Route("api/authenticate")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
