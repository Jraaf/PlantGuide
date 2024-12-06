using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class Plant
{
    public int PlantId { get; set; }

    public string? ScientificName { get; set; }

    public string? CommonName { get; set; }

    public string? Description { get; set; }
    [JsonIgnore]
    public virtual ICollection<Climate> Climates { get; set; } = new List<Climate>();
    [JsonIgnore]
    public virtual ICollection<FamilyPlant> FamilyPlants { get; set; } = new List<FamilyPlant>();
    [JsonIgnore]
    public virtual ICollection<FloweringSeasonPlant> FloweringSeasonPlants { get; set; } = new List<FloweringSeasonPlant>();
    [JsonIgnore]
    public virtual ICollection<Origin> Origins { get; set; } = new List<Origin>();
    [JsonIgnore]
    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();
    [JsonIgnore]
    public virtual ICollection<SourcePlant> SourcePlants { get; set; } = new List<SourcePlant>();
}
