using Microsoft.AspNetCore.Mvc;

namespace SkypeApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
