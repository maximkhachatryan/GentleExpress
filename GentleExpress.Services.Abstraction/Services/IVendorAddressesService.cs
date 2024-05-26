using GentleExpress.Models.Districts;
using GentleExpress.Models.VendorAddresses;

namespace GentleExpress.Services.Abstraction.Services;

public interface IVendorAddressesService
{
    Task<List<VendorAddressDTO>> GetVendorAddresses(int vendorId, bool showRemoved = false);
}
