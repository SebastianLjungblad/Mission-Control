using Microsoft.AspNetCore.Mvc;
using MissionControl.Core.Clients;

namespace MissionControl.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CelesTrakController : ControllerBase
{
    private readonly CelesTrakClient _client;

    public CelesTrakController(CelesTrakClient client)
    {
        _client = client;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var satellites = await _client.GetStationsAsync();

        return Ok(satellites.Take(10));
    }
}