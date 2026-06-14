using MissionControl.Core.Entities;

namespace MissionControl.Core.Services;

public interface ISatelliteService
{
    Task<IEnumerable<Satellite>> GetAllAsync();

    Task<Satellite?> GetByIdAsync(int id);
}