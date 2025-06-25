using Revision_Project.Models;

namespace Revision_Project.Interface
{
    public interface IUserRepository
    {
        Task AddNewUser(User user);                            // Create/Update
        Task UpdateUser(User user);                            // Create/Update

        Task<List<User>> GetAllUser();                             // Read All
        Task<User?> FindByUserName(Guid id);                       // Read by ID
        Task DeleteById(Guid id);                            // Delete
        Task<User?> FindByUserName(string userName);         // Read by Username
       

    }
}
