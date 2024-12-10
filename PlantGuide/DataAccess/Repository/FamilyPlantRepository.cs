using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class FamilyPlantRepository : Repo<FamilyPlant, int>, IFamilyPlantRepository
{
    private readonly PlantguideContext context;

    public FamilyPlantRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }

    public async Task<List<FamilyPlant>> GetByPlantId(int plantId)
    {
        return await context.FamilyPlants
            .Include(fp => fp.Plant)
            .Include(fp => fp.Family)
            .Where(fp => fp.PlantId == plantId)
            .ToListAsync();
    }
}
