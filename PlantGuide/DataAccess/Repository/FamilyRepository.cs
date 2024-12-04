using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class FamilyRepository : Repo<Family, int>, IFamilyRepository
{
    public FamilyRepository(PlantguideContext context)
        : base(context)
    {

    }
}
