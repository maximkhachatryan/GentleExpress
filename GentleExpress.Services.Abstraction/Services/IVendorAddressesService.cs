using GentleExpress.Models.Districts;
using GentleExpress.Models.VendorAddresses;
using GentleExpress.Models.Vendors;

namespace GentleExpress.Services.Abstraction.Services;

public interface IVendorAddressesService
{
    Task<VendorAddressDTO> CreateVendorAddress(int vendorId, CreateVendorAddressRequest request);
    Task RemoveVendorAddress(int vendorAddressId);
    Task<List<VendorAddressDTO>> GetVendorAddresses(int vendorId, bool showRemoved = false);
}
