using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class TypeSeason
{
    public int TypeSeasonId { get; set; }

    public string? Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<FloweringSeasonPlant> FloweringSeasonPlants { get; set; } = new List<FloweringSeasonPlant>();
}
