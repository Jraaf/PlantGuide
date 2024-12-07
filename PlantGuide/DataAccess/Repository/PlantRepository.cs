using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class PlantRepository : Repo<Plant, int>, IPlantRepository
{
    private readonly PlantguideContext context;

    public PlantRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }

    public async Task<Plant?> AssignFloweringSeason(FloweringSeasonPlant fsp)
    {
        var data = await context.FloweringSeasonPlants.AddAsync(fsp);
        await context.SaveChangesAsync();
        return await context.Plants
            .Include(c => c.FloweringSeasonPlants)
            .FirstOrDefaultAsync(p => p.FloweringSeasonPlants
                .Any(fp => fp.FloweringSeasonPlantId == data.Entity.FloweringSeasonPlantId));
    }
}
