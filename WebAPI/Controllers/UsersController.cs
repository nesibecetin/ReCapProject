using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getbyemail")]
        public IActionResult GetById(string email)
        {
            var result = _userService.GetByMail(email);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int userId)
        {
            var result = _userService.GetById(userId);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateUser")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.isSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
