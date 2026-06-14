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
    public IActionResult GetAll()
    {
        var satellites = _satelliteService
            .GetAll()
            .Select(s => new SatelliteDto
            {
                Id = s.Id,
                Name = s.Name,
                NoradId = s.NoradId
            });

        return Ok(satellites);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var satellite = _satelliteService.GetById(id);

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