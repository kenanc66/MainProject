using Business.Abstract;
using Business.BusinessAspects.Autofac;
using DataAccess.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IUserDal _userDal;
        private readonly IUserService _userService;

        public AuthController(IAuthService authService,IUserDal userDal,IUserService userService)
        {
            _authService = authService;
            _userDal = userDal;
            _userService = userService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
        [SecuredOperation("user")]
        [HttpGet("account")]
        public ActionResult Account()
        {
            var testClaim = User.Claims.ElementAt(0);
            int userId=int.Parse(testClaim.Value);
            var userInfo = _userDal.Get(n => n.Id == userId);
            AccountDto accountDto = new AccountDto {
                Id = userInfo.Id,
                FirstName =userInfo.FirstName,
                Email = userInfo.Email,
                LastName =userInfo.LastName

            };
            return Ok(accountDto);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                _userService.AddRole(registerResult.Data, 3);
                return Ok(result.Data);

            }

            return BadRequest(result.Message);
        }
    }
}
