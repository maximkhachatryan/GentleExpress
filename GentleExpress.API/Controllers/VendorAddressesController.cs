using GentleExpress.Models.VendorAddresses;
using GentleExpress.Models.Vendors;
using GentleExpress.Services.Abstraction.Services;
using GentleExpress.Services.EFCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VendorAddressesController(IVendorAddressesService vendorAddressesService) : ControllerBase
{
    [HttpGet("vendor/{vendorId}")]
    public Task<List<VendorAddressDTO>> Get(int vendorId) => vendorAddressesService.GetVendorAddresses(vendorId);

    [HttpPost("vendor/{vendorId}")]
    public Task<VendorAddressDTO> CreateVendorAddress(int vendorId, CreateVendorAddressRequest request)
        => vendorAddressesService.CreateVendorAddress(vendorId, request);

    [HttpDelete("{vendorAddressId}")]
    public Task DeleteVendorAddress(int vendorAddressId)
        => vendorAddressesService.RemoveVendorAddress(vendorAddressId);
}
