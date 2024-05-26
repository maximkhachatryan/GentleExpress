using GentleExpress.Models.Couriers;
using GentleExpress.Models.Vendors;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VendorsControllers(IVendorsService vendorsService) : ControllerBase
{

    [HttpGet]
    public Task<List<VendorDTO>> Get() => vendorsService.GetVendors();
}
