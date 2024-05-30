using GentleExpress.Models.Vendors;

namespace GentleExpress.Services.Abstraction.Services;

public interface IVendorsService
{
    Task<VendorDTO> CreateVendor(CreateVendorRequest request);
    Task<List<VendorDTO>> GetVendors();
    Task<VendorDTO> UpdateVendor(UpdateVendorRequest request);
}
