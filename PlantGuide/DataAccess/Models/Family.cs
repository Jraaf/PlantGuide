using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Family
{
    public int FamilyId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FamilyPlant> FamilyPlants { get; set; } = new List<FamilyPlant>();
}
