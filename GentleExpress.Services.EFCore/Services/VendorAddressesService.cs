using GentleExpress.Models.VendorAddresses;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class VendorAddressesService(GentleExpressPostgresDbContext context) : IVendorAddressesService
{
    public Task<List<VendorAddressDTO>> GetVendorAddresses(int vendorId, bool showRemoved = false)
    {
        return context.VendorAddresses
            .Where(va => va.VendorId == vendorId
                && (showRemoved || va.IsRemoved == false))
            .Select(va => new VendorAddressDTO
            {
                Id = va.Id,
                DistrictId = va.DistrictId,
                Address = va.Address
            })
            .ToListAsync();
    }
}
