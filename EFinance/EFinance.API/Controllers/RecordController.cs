using EFinance.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFinance.Api.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Produces("application/json")]
    [Route("api/record")]
    public class RecordController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostRecord(Register register)
        {
            return Ok(register);
        }
    }
}
