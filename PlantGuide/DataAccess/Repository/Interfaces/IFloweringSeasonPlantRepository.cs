﻿using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface IFloweringSeasonPlantRepository : IRepo<FloweringSeasonPlant,int>
{
    Task<List<FloweringSeasonPlant>> GetByPlantId(int plantId);
}
