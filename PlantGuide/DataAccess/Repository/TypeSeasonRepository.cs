using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class TypeSeasonRepository : Repo<TypeSeason, int>, ITypeSeasonRepository
{
    private readonly PlantguideContext context;

    public TypeSeasonRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<TypeSeason>> GetAllAsync()
    {
        return await context.TypeSeasons
            .Include(tp => tp.FloweringSeasonPlants)
                .ThenInclude(fp=>fp.Plant)
            .ToListAsync();
    }
    public async new Task<TypeSeason?> GetAsync(int id)
    {
        return await context.TypeSeasons
            .Include(tp => tp.FloweringSeasonPlants)
                .ThenInclude(fp => fp.Plant)
            .FirstOrDefaultAsync(o => o.TypeSeasonId == id);
    }

    public async Task<List<TypeSeason>> GetByPlantId(int plantId)
    {
        return await context.TypeSeasons
            .Include(tp => tp.FloweringSeasonPlants)
            .Where(ts => ts.FloweringSeasonPlants
                        .Any(fsp => fsp.PlantId == plantId))
            .ToListAsync();
    }
}
