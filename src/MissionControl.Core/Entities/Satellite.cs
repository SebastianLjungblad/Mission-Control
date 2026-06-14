namespace MissionControl.Core.Entities;

public class Satellite
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string NoradId { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; } 

    public double Altitude { get; set; }

    public double Velocity { get; set; }

}