﻿using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IFamilyPlantRepository : IRepo<FamilyPlant, int>
{
    Task<List<FamilyPlant>> GetByPlantId(int plantId);
}
