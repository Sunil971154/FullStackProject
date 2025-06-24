using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Revision_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok("Ok--> http://localhost:5172");
        }


    }
}
