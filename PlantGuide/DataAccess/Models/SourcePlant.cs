using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class SourcePlant
{
    public int SourcesPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? SourceId { get; set; }

    public virtual Plant? Plant { get; set; }

    public virtual Source? Source { get; set; }
}
