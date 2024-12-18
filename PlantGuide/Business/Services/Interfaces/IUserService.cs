using PlantGuide.Business.DTO;
using PlantGuide.DataAccess.Models;

namespace PlantGuide.Business.Services.Interfaces;

public interface IUserService
{
    Task<bool> UserExists(string username);
    Task<UserDTO> Register(CreateUserDTO user);
    Task<UserDTO> Login(LoginUserDTO user);
    string CreateToken(User user);
}
