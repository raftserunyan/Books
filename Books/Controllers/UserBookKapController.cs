using Books.Models;
using Books.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookKapController : ControllerBase
    {
        private readonly UserBookKapService kapService;

        public UserBookKapController(UserBookKapService _kapService)
        {
            kapService = _kapService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(kapService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(UserBookKap kap)
        {
            kapService.Add(kap);

            return Ok();
        }
    }
}
