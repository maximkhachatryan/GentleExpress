using GentleExpress.Models.VendorAddresses;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VendorAddressesController(IVendorAddressesService vendorAddressesService) : ControllerBase
{
    [HttpGet("vendor/{vendorId}")]
    public Task<List<VendorAddressDTO>> Get(int vendorId) => vendorAddressesService.GetVendorAddresses(vendorId);
}
