using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;
using System.Net.Security;

namespace PlantGuide.DataAccess.Repository;

public class OriginRepository : Repo<Origin, int>, IOriginRepository
{
    private readonly PlantguideContext context;

    public OriginRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Origin>> GetAllAsync()
    {
        return await context.Origins
            .Include(o=>o.Country)
            .ToListAsync();
    }
    public async new Task<Origin?> GetAsync(int id)
    {
        return await context.Origins
            .Include(o=>o.Country)
            .FirstOrDefaultAsync(o=>o.OriginId == id);
    }
}
