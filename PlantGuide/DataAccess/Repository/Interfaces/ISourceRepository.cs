﻿using DataAccess.Models;
using DataAccess.Repository.Base;

namespace PlantGuide.DataAccess.Repository.Interfaces;

public interface ISourceRepository : IRepo<Source, int>
{
    Task<List<Source>> GetByPlantId(int plantId);
}
