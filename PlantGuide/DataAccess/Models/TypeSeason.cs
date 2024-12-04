using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TypeSeason
{
    public int TypeSeasonId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FloweringSeasonPlant> FloweringSeasonPlants { get; set; } = new List<FloweringSeasonPlant>();
}
