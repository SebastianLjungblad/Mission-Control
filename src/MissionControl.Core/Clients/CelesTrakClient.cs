namespace MissionControl.Core.Clients;
using MissionControl.Core.Models;

public class CelesTrakClient
{
    private readonly HttpClient _httpClient;

    public CelesTrakClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetStationsTleAsync()
    {
        return await _httpClient.GetStringAsync(
            "https://celestrak.org/NORAD/elements/gp.php?GROUP=stations&FORMAT=tle"
        );
    }

    public async Task<List<TleSatellite>> GetStationsAsync()
{
    var tleText = await GetStationsTleAsync();

        var lines = tleText
            .Split('\n', StringSplitOptions.RemoveEmptyEntries);

        var satellites = new List<TleSatellite>();

        for (int i = 0; i < lines.Length; i += 3)
        {
            if (i + 2 >= lines.Length)
            {
                break;
            }

            satellites.Add(new TleSatellite
            {
                Name = lines[i].Trim(),
                Line1 = lines[i + 1].Trim(),
                Line2 = lines[i + 2].Trim()
            });
        }

        return satellites;
}
}