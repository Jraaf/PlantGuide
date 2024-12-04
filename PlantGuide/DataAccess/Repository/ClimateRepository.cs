using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class ClimateRepository : Repo<Climate,int>,IClimateRepository
{
    public ClimateRepository(PlantguideContext context)
        :base(context)
    {
        
    }
}
