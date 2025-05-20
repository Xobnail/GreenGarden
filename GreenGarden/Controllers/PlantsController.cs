using GreenGarden.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GreenGarden.Host.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlantsController(IPlantsService plantsService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
    {
        return Ok(await plantsService.GetPlantsAsync(cancellationToken));
    }

    [HttpGet]
    [Route("Test")]
    public async Task<IActionResult> TestAsync(CancellationToken cancellationToken)
    {
        return Ok(await plantsService.TestAsync(cancellationToken));
    }
}
