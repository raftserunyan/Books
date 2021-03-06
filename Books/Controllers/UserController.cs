using Books.Models;
using Books.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }

        [HttpGet("{name}")]
        public IActionResult GetUserBooksByUserName(string name)
        {
            return Ok(userService.GetAllWithBooksByName(name));
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            userService.Add(user);

            return Ok();
        }

        [HttpPost("{userId}/addBook/{bookId}")]
        public IActionResult AddBook(int userId, int bookId)
        {
            userService.AddBook(userId, bookId);

            return Ok();
        }
    }
}
