using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace MyWbsiteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            _userServices.Register(userRegisterDTO);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Login(string email, string password)
        {
            var isValidUser = _userServices.Login(email, password);

            if (isValidUser)
                return Ok();

            return BadRequest();
        }

        
    }
}
