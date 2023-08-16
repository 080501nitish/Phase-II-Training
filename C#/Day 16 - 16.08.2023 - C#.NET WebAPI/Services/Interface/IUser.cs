using JWTAPI.Models;

namespace JWTAPI.Services.Interface
{
    public interface IUser
    {
        Task<User> GetUserByUserName(string username);
        Task<List<User>> AddUser(User user);
        Task<User> UpdateUser(string username, User user);
        Task<List<User>> DeleteUser(string username);

    }
}
