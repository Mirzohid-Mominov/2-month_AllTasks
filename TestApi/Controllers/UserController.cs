using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BackendTest.Services;
using BackendTest.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("user")]
        public User AddUser(User user)
        {
            _userService.AddUser(user);
            return user;
        }

    }
}
