using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class OriginRepository : Repo<Origin, int>, IOriginRepository
{
    public OriginRepository(PlantguideContext context)
        : base(context)
    {

    }
}
