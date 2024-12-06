using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class CountryRepository : Repo<Country, int>, ICountryRepository
{
    private readonly PlantguideContext context;

    public CountryRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Country>> GetAllAsync()
    {
        return await context.Countries
            .Include(c=>c.Origins)
            .ToListAsync();
    }
    public async new Task<Country?> GetAsync(int id)
    {
        return await context.Countries
            .Include(c => c.Origins)
            .FirstOrDefaultAsync(c => c.CountryId == id);
    }
}
