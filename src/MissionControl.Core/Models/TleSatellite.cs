namespace MissionControl.Core.Models;

public class TleSatellite
{
    public string Name { get; set; } = string.Empty;

    public string Line1 { get; set; } = string.Empty;

    public string Line2 { get; set; } = string.Empty;

        public string NoradId
    {
        get
        {
            var parts = Line1.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries);

            return parts.Length > 1
                ? parts[1].Replace("U", "")
                : string.Empty;
        }
    }
}