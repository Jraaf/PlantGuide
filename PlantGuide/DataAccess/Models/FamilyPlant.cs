using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Models;

public partial class FamilyPlant
{
    public int FamilyPlantId { get; set; }

    public int? PlantId { get; set; }

    public int? FamilyId { get; set; }
    [JsonIgnore]
    public virtual Family? Family { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual Plant? Plant { get; set; }
}
