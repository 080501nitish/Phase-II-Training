using JWT.Models;
using JWTAPI.Models;
using JWTAPI.Services.Interface;
using Microsoft.EntityFrameworkCore;
using JWT.Global_Exceptions;

namespace JWTAPI.Services
{
    public class UserService : IUser
    {
        private StudentDbContext _context;

        public UserService(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var ruser=await _context.Users.FirstOrDefaultAsync(i => i.Username == username);
            if (ruser !=null)
            {
                _context.Users.Remove(ruser);
                _context.SaveChanges();
                return await _context.Users.ToListAsync();
            }
            else
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }

        }

        public async Task<User> GetUserByUserName(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(i => i.Username == username);
            if(user == null)
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }
            else
            {
                return user;
            }
        }

        public async Task<User> UpdateUser(string username, User user)
        {

            var ruser = await _context.Users.FirstOrDefaultAsync(i => i.Username == username);
            if (ruser != null)
            {
                ruser.Password=user.Password;
                ruser.Role=user.Role;

                await _context.SaveChangesAsync();
                ruser = await _context.Users.FirstOrDefaultAsync(i => i.Username == username);
                return ruser;
            }
            else
            {
                throw new Exception(StudentDetailsExceptions.StudentnotFoundException[0]);
            }
        }
    }
}
