﻿using JWT.Models;
using JWTAPI.Models;
using JWTAPI.Services.Interface;
using MathNet.Numerics.Statistics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            var users = await _user.AddUser(user);
            return Ok(users);
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUser(string username)
        {
            try
            {
                var users = await _user.DeleteUser(username);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]

        public async Task<ActionResult<User>> UpdateUser(string username, User user)
        {
            try
            {
                var users = await _user.UpdateUser(username, user);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUserByUserName(string username)
        {
            User users;
            try
            {
               users = await _user.GetUserByUserName(username);
            }
            catch(Exception ex) 
            {
                return NotFound(ex.Message);
            }
            return Ok(users);

        }
    }

}
