using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class Origin
{
    public int OriginId { get; set; }

    public int? PlantId { get; set; }

    public int? CountryId { get; set; }

    public int? Years { get; set; }
    [JsonIgnore]
    public virtual Country? Country { get; set; }
    [JsonIgnore]
    public virtual Plant? Plant { get; set; }
}
