using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository
{
    public class FamilyPlantRepository:Repo<FamilyPlant,int>, IFamilyPlantRepository
    {
        public FamilyPlantRepository(PlantguideContext context)
            :base(context)
        {
            
        }
    }
}
