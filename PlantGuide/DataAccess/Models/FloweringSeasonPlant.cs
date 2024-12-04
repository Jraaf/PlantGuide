using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class FloweringSeasonPlant
{
    public int FloweringSeasonPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? TypeSeasonId { get; set; }

    public virtual Plant? Plant { get; set; }

    public virtual TypeSeason? TypeSeason { get; set; }
}
