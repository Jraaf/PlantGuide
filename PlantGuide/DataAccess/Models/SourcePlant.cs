using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class SourcePlant
{
    public int SourcesPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? SourceId { get; set; }

    public virtual Plant? Plant { get; set; }
    [JsonIgnore]
    public virtual Source? Source { get; set; }
}
