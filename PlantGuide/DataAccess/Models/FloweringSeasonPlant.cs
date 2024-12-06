using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class FloweringSeasonPlant
{
    public int FloweringSeasonPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? TypeSeasonId { get; set; }
    [JsonIgnore]
    public virtual Plant? Plant { get; set; }
    [JsonIgnore]
    public virtual TypeSeason? TypeSeason { get; set; }
}
