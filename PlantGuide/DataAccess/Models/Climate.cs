using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Climate
{
    public int ClimateId { get; set; }

    public int? PlantId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? TemperatureMin { get; set; }

    public double? TemperatureMax { get; set; }

    public double? PrecipitationMin { get; set; }

    public double? PrecipitationMax { get; set; }

    public virtual Plant? Plant { get; set; }
}
