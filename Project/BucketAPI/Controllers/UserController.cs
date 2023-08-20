using Bucket.Models;
using Bucket.Service.Interface;
using MathNet.Numerics.Distributions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Bucket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUsers _bucket;

        public UserController(IUsers bucket) 
        {
            _bucket = bucket;
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUsers(User user)
        {
            var users = await _bucket.AddUsers(user);
            return Ok(users);
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUsers (int id)
        {
            try
            {
                var users = await _bucket.DeleteUsers(id);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]

        public async Task<ActionResult<User>> UpdateUsers(int id, User user)
        {
            try
            {
                var users = await _bucket.UpdateUsers(id, user);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



    }
}
