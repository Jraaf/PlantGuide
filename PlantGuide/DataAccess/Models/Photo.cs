using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Photo
{
    public int PhotoId { get; set; }

    public int? PlantId { get; set; }

    public string? Url { get; set; }

    public string? Author { get; set; }

    public virtual Plant? Plant { get; set; }
}
