using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PaulExpress.Api.Authentication;
using PaulExpress.Domain.Dtos.Internal;
using PaulExpress.Domain.Dtos.Simple;

namespace PaulExpress.Api.Controllers
{
    [Authorize()]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly JWTUserService _userService;

        public UsersController(JWTUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public ActionResult<UserDto> Authenticate([FromBody] AuthenticateDto auth)
        {
            UserDto user = _userService.Authenticate(auth);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
    }
}