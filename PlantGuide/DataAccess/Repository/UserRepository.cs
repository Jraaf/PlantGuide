using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Models;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class UserRepository : Repo<User, int>, IUserRepository
{
    private readonly PlantguideContext _context;
    public UserRepository(PlantguideContext context)
        : base(context)
    {
        _context = context;
    }
    public async Task<User?> GetByUsername(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(x =>
                     x.Username.ToLower() == username.ToLower());
    }

    public async Task<bool> UserExists(string username)
    {
        return await _context.Users.AnyAsync(x =>
            x.Username.ToLower() == username.ToLower());
    }
}