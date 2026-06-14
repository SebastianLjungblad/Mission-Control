using MissionControl.Core.Entities;

namespace MissionControl.Core.Services;

public class SatelliteService : ISatelliteService
{
    private readonly List<Satellite> _satellites =
    [
        new()
        {
            Id = 1,
            Name = "ISS",
            NoradId = "25544",
            Latitude = 0,
            Longitude = 0,
            Altitude = 420,
            Velocity = 27600
        },

        new()
        {
            Id = 2,
            Name = "Hubble",
            NoradId = "20580",
            Latitude = 0,
            Longitude = 0,
            Altitude = 540,
            Velocity = 27500
        }
    ];

        public Task<IEnumerable<Satellite>> GetAllAsync()
    {
        return Task.FromResult(_satellites.AsEnumerable());
    }

    public Task<Satellite?> GetByIdAsync(int id)
    {
        return Task.FromResult(
            _satellites.FirstOrDefault(x => x.Id == id)
        );
    }
}