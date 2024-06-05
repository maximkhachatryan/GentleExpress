using GentleExpress.Models.VendorAddresses;
using GentleExpress.Models.Vendors;
using GentleExpress.Repositories.Abstraction.Entities;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class VendorAddressesService(GentleExpressPostgresDbContext context) : IVendorAddressesService
{
    public async Task<VendorAddressDTO> CreateVendorAddress(int vendorId, CreateVendorAddressRequest request)
    {
        var vendorEntity = context.VendorAddresses.Add(new VendorAddress
        {
            VendorId = vendorId,
            DistrictId = request.DistrictId,
            Address = request.Address,
            IsRemoved = false
        });

        await context.SaveChangesAsync();

        return new VendorAddressDTO
        {
            Id = vendorEntity.Entity.Id,
            Address = vendorEntity.Entity.Address,
            DistrictId = vendorEntity.Entity.DistrictId
        };
    }

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

    public Task RemoveVendorAddress(int vendorAddressId)
    {
        var vendorAddress = context.VendorAddresses.FirstOrDefault(v => v.Id == vendorAddressId);
        if (vendorAddress == null)
            throw new Exception($"Vendor address id {vendorAddressId} not found");

        vendorAddress.IsRemoved = true;

        return context.SaveChangesAsync();
    }
}
