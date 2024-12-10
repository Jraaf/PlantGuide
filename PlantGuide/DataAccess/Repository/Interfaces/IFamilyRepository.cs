using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IFamilyRepository : IRepo<Family, int>
{
    Task<List<Family>> GetByPlantId(int plantId);
}
