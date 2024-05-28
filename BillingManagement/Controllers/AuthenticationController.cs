using BillingManagement.Controllers;
using Ekart.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Ekart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly Ekart.Services.AuthenticationService _authenticationService;
        //private readonly HomeController  _homeController;

        public AuthenticationController(AuthenticationService authenticationService  /*HomeController homeController*/)
        {
           _authenticationService = authenticationService;
//            _homeController = homeController;   

        }

       

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest model)
        {
            var token = _authenticationService.Authenticate(model.Username, model.Password);
            if (token == null)
                return Unauthorized("Invalid username or password");

            //return _homeController.Index();
            return Ok(new { Token = token });
        }

       
    }

    public class LoginRequest
    {   
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
