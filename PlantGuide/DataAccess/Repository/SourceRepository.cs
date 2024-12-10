using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class SourceRepository : Repo<Source, int>, ISourceRepository
{
    private readonly PlantguideContext context;

    public SourceRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Source>> GetAllAsync()
    {
        return await context.Sources
            .Include(o => o.SourcePlants)
                .ThenInclude(sp=>sp.Plant)
            .ToListAsync();
    }
    public async new Task<Source?> GetAsync(int id)
    {
        return await context.Sources
            .Include(o => o.SourcePlants)
                .ThenInclude(sp => sp.Plant)
            .FirstOrDefaultAsync(o => o.SourceId == id);
    }

    public async Task<List<Source>> GetByPlantId(int plantId)
    {
        return await context.Sources
            .Include(s => s.SourcePlants)
            .Where(s => s.SourcePlants
                        .Any(sp => sp.PlantId == plantId))
            .ToListAsync();
    }
}
