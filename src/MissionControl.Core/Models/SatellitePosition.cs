namespace MissionControl.Core.Models;

public class SatellitePosition
{
    public string Name { get; set; } = string.Empty;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double AltitudeKm { get; set; }
}