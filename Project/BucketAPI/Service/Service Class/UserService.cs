using Bucket.Context;
using Bucket.Global_Exceptions;
using Bucket.Models;
using Bucket.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bucket.Service.Service_Class
{
    public class UserService : IUsers
    {
        public BucketContext _userContext;

        public UserService(BucketContext bucketContext)
        {
               _userContext = bucketContext;
        }
        public async Task<List<User>> AddUsers(User user)
        {

            if (await _userContext.Users.AnyAsync(u => u.UserName == user.UserName))
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["AlreadyExists"]);
            }
            if (await _userContext.Users.AnyAsync(u => u.UserEmail == user.UserEmail))
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["AlreadyExists"]);
            }
            _userContext.Users.Add(user);
                await _userContext.SaveChangesAsync();
                return await _userContext.Users.ToListAsync();
            
           
        }

        public  async Task<List<User>> DeleteUsers(int id)
        {
            User users = await _userContext.Users.FindAsync(id);
            if (users == null)
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["NotFound"]);
            }
            else
            {
                _userContext.Remove(users);
                await _userContext.SaveChangesAsync();
                return await _userContext.Users.ToListAsync();
            }
            /*   throw new NotImplementedException();*/
        }

        public async Task<User> UpdateUsers(int id, User user)
        {
            User ruser= await _userContext.Users.FindAsync(id);
            if (ruser == null)
            {
                throw new Exception(UserDetailsExceptions.UsernotFoundException["NotFound"]);
            }
            else
            {
                ruser.UserName = user.UserName;
                ruser.UserEmail = user.UserEmail;
                ruser.UserPassword = user.UserPassword;
                ruser.UserPrfilePicture = user.UserPrfilePicture;
                ruser.UserBio = user.UserBio;

                await _userContext.SaveChangesAsync();

                ruser = await _userContext.Users.FindAsync(id);
                return ruser;
            }
        }
    }
}
