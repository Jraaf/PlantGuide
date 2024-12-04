using DataAccess.Models;
using DataAccess.Repository.Base;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class CountryRepository : Repo<Country, int>, ICountryRepository
{
    public CountryRepository(PlantguideContext context)
        : base(context)
    {

    }
}
