using Bucket.Models;

namespace Bucket.Service.Interface
{
    public interface IUsers
    {
        //Users API Endpoint
        Task<List<User>> AddUsers(User users);
        Task<User> UpdateUsers(int id, User users);
        Task<List<User>> DeleteUsers(int id);

        

    }
}
