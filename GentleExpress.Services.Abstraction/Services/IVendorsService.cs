using GentleExpress.Models.Vendors;

namespace GentleExpress.Services.Abstraction.Services;

public interface IVendorsService
{
    Task<List<VendorDTO>> GetVendors();
}
