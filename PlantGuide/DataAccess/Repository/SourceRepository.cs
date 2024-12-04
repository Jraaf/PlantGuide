using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class SourceRepository : Repo<Source, int>, ISourceRepository
{
    public SourceRepository(PlantguideContext context)
        : base(context)
    {

    }
}
