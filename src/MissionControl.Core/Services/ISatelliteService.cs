using MissionControl.Core.Entities;

namespace MissionControl.Core.Services;

public interface ISatelliteService
{
    IEnumerable<Satellite> GetAll();
    Satellite? GetById(int id);
}