using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class Source
{
    public int SourceId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Author { get; set; }
    [JsonIgnore]
    public virtual ICollection<SourcePlant> SourcePlants { get; set; } = new List<SourcePlant>();
}
