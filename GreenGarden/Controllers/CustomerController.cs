using GreenGarden.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace GreenGarden.Host.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomersService customersService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
    {
        return Ok(await customersService.GetCustomersAsync(cancellationToken));
    }
}
