using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class SourcePlantRepository : Repo<SourcePlant, int>, ISourcePlantRepository
{
    private readonly PlantguideContext context;

    public SourcePlantRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }

    public async Task<List<SourcePlant>> GetByPlantId(int plantId)
    {
        return await context.SourcePlants
            .Include(sp=>sp.Source)
            .Include(sp=>sp.Plant)
            .Where(sp=>sp.PlantId == plantId)
            .ToListAsync();
    }
}
