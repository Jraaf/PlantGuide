using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IPhotoRepository : IRepo<Photo, int>
{
    Task<List<Photo>> GetByPlantId(int plantId);
}
