using DataAccess.Repository.Base;
using PlantGuide.DataAccess.Models;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IUserRepository : IRepo<User, int>
{
    Task<bool> UserExists(string username);
    Task<User> GetByUsername(string username);
}
