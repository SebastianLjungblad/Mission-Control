namespace MissionControl.Core.Entities;

public class Telemetry
{
    public int Id { get; set; }

    public int SatelliteId { get; set; }

    public DateTime Timestamp { get; set; }

    public double Battery { get; set; }

    public double Temperature { get; set; }

    public double Altitude { get; set; }

    public double Velocity { get; set; }
}