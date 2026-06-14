namespace MissionControl.Core.Entities;

public class EventLog
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;
}