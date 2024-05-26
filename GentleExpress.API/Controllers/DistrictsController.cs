using GentleExpress.Models.Districts;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DistrictsController(IDistrictsService districtsService) : ControllerBase
{

    [HttpGet("city/{cityId}")]
    public Task<List<DistrictDTO>> Get(int cityId) => districtsService.GetDistrictsByCityId(cityId);

}
