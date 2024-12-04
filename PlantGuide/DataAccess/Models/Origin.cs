using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Origin
{
    public int OriginId { get; set; }

    public int? PlantId { get; set; }

    public int? CountryId { get; set; }

    public int? Years { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Plant? Plant { get; set; }
}
