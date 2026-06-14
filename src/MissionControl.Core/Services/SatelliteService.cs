using MissionControl.Core.Clients;
using MissionControl.Core.Entities;

namespace MissionControl.Core.Services;

public class SatelliteService : ISatelliteService
{
    private readonly CelesTrakClient _celesTrakClient;

    public SatelliteService(CelesTrakClient celesTrakClient)
    {
        _celesTrakClient = celesTrakClient;
    }

    public async Task<IEnumerable<Satellite>> GetAllAsync()
    {
        var tleSatellites = await _celesTrakClient.GetStationsAsync();

        return tleSatellites.Select((satellite, index) => new Satellite
        {
            Id = index + 1,
            Name = satellite.Name,

            NoradId = satellite.NoradId,

            Latitude = 0,
            Longitude = 0,
            Altitude = 0,
            Velocity = 0
        });
    }

    public async Task<Satellite?> GetByIdAsync(int id)
    {
        var satellites = await GetAllAsync();

        return satellites.FirstOrDefault(x => x.Id == id);
    }
}