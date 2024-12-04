using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface ICountryRepository : IRepo<Country, int>
{
}
