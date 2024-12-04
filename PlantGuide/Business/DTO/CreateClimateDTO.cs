namespace PlantGuide.Business.DTO;

public class CreateClimateDTO
{
    public int? PlantId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? TemperatureMin { get; set; }

    public double? TemperatureMax { get; set; }

    public double? PrecipitationMin { get; set; }

    public double? PrecipitationMax { get; set; }
}
