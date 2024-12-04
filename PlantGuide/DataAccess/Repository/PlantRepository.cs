using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class PlantRepository: Repo<Plant, int>,IPlantRepository
{
    public PlantRepository(PlantguideContext context)
        :base(context)
    {
        
    }
}
