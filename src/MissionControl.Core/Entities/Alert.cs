namespace MissionControl.Core.Entities;

public class Alert
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Severity { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}