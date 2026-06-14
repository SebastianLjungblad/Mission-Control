using Microsoft.AspNetCore.Mvc;
using MissionControl.Core.Services;
using MissionControl.Api.Dtos;

namespace MissionControl.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SatellitesController : ControllerBase
{
    private readonly ISatelliteService _satelliteService;

    public SatellitesController(ISatelliteService satelliteService)
    {
        _satelliteService = satelliteService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var satellites = await _satelliteService.GetAllAsync();

        var satelliteDtos = satellites.Select(s => new SatelliteDto
        {
            Id = s.Id,
            Name = s.Name,
            NoradId = s.NoradId
        });

        return Ok(satelliteDtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var satellite = await _satelliteService.GetByIdAsync(id);

        if (satellite is null)
        {
            return NotFound();
        }

        var satelliteDto = new SatelliteDto
        {
            Id = satellite.Id,
            Name = satellite.Name,
            NoradId = satellite.NoradId
        };

        return Ok(satelliteDto);
    }
}