using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class SourcePlantRepository : Repo<SourcePlant, int>, ISourcePlantRepository
{
    public SourcePlantRepository(PlantguideContext context)
        : base(context)
    {

    }
}
