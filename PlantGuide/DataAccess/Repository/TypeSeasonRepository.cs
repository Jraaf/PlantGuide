using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class TypeSeasonRepository : Repo<TypeSeason, int>, ITypeSeasonRepository
{
    public TypeSeasonRepository(PlantguideContext context)
        : base(context)
    {

    }
}
