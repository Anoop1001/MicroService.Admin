using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController()
        {

        }

        [HttpGet("get")]
        public ActionResult<string> GetMyName()
        {
            return nameof(AdminController);
        }
    }
}
