using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;
using PlantGuide.Migrations;

namespace PlantGuide.DataAccess.Repository;

public class ClimateRepository : Repo<Climate, int>, IClimateRepository
{
    private readonly PlantguideContext context;

    public ClimateRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Climate>> GetAllAsync()
    {
        return await context.Climates
            .Include(c=>c.Plant)
            .ToListAsync();
    }
    public async new Task<Climate?> GetAsync(int id)
    {
        return await context.Climates
            .Include(c => c.Plant)
            .FirstOrDefaultAsync(c=>c.ClimateId == id);
    }

    public async Task<Climate?> GetByPlantId(int plantId)
    {
        return await context.Climates
            .Include(c => c.Plant)
            .FirstOrDefaultAsync(c => c.PlantId == plantId);
    }
}
