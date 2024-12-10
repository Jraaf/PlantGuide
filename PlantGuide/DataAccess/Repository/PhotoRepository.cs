using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class PhotoRepository : Repo<Photo, int>, IPhotoRepository
{
    private readonly PlantguideContext context;

    public PhotoRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Photo>> GetAllAsync()
    {
        return await context.Photos
            .Include(o => o.Plant)
            .ToListAsync();
    }
    public async new Task<Photo?> GetAsync(int id)
    {
        return await context.Photos
            .Include(o => o.Plant)
            .FirstOrDefaultAsync(o => o.PhotoId == id);
    }

    public async Task<List<Photo>> GetByPlantId(int plantId)
    {
        return await context.Photos
            .Where(p => p.PlantId == plantId)
            .ToListAsync();
    }
}
