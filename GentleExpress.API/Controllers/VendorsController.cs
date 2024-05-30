using GentleExpress.Models.Vendors;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VendorsController(IVendorsService vendorsService) : ControllerBase
{

    [HttpGet]
    public Task<List<VendorDTO>> Get() => vendorsService.GetVendors();

    [HttpPost]
    public Task<VendorDTO> CreateVendor(CreateVendorRequest request)
        => vendorsService.CreateVendor(request);

    [HttpPut]
    public Task<VendorDTO> UpdateVendor(UpdateVendorRequest request)
        => vendorsService.UpdateVendor(request);
}
