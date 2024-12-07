using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class FamilyRepository : Repo<Family, int>, IFamilyRepository
{
    private readonly PlantguideContext context;

    public FamilyRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Family>> GetAllAsync()
    {
        return await context.Families
            .Include(c => c.FamilyPlants)
                .ThenInclude(c => c.Plant)
            .ToListAsync();
    }
    public async new Task<Family?> GetAsync(int id)
    {
        return await context.Families 
            .Include(c => c.FamilyPlants)
                .ThenInclude(c=>c.Plant)
            .FirstOrDefaultAsync(c => c.FamilyId == id);
    }
}
