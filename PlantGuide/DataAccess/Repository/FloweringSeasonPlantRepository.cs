using DataAccess.Models;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using PlantGuide.DataAccess.EF;
using PlantGuide.DataAccess.Repository.Interfaces;

namespace PlantGuide.DataAccess.Repository;

public class FloweringSeasonPlantRepository: Repo<FloweringSeasonPlant,int>, IFloweringSeasonPlantRepository
{
    private readonly PlantguideContext context;

    public FloweringSeasonPlantRepository(PlantguideContext context)
        : base(context)
    {
        this.context = context;
    }
}
