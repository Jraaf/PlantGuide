using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Origin> Origins { get; set; } = new List<Origin>();
}
