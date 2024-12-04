using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Source
{
    public int SourceId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public string? Author { get; set; }

    public virtual ICollection<SourcePlant> SourcePlants { get; set; } = new List<SourcePlant>();
}
