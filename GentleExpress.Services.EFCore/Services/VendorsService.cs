using GentleExpress.Models.Vendors;
using GentleExpress.Repositories.Abstraction.Entities;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class VendorsService(GentleExpressPostgresDbContext context)
    : IVendorsService
{
    public async Task<VendorDTO> CreateVendor(CreateVendorRequest request)
    {
        var vendorEntity = await context.Vendors.AddAsync(new Vendor
        {
            Code = request.Code,
            Name = request.Name,
            BrandName = request.BrandName,
            PhoneNumber1 = request.PhoneNumber1,
            PhoneNumber2 = request.PhoneNumber2
        });

        return new VendorDTO
        {
            Id = vendorEntity.Entity.Id,
            Code = vendorEntity.Entity.Code,
            Name = vendorEntity.Entity.Name,
            BrandName = vendorEntity.Entity.BrandName,
            PhoneNumber1 = vendorEntity.Entity.PhoneNumber1,
            PhoneNumber2 = vendorEntity.Entity.PhoneNumber2,
            VendorWalletAmount = vendorEntity.Entity.VendorWalletAmount
        };
    }

    public Task<List<VendorDTO>> GetVendors()
    {
        return context.Vendors.Select(v => new VendorDTO
        {
            Id = v.Id,
            Code = v.Code,
            Name = v.Name,
            BrandName = v.BrandName,
            PhoneNumber1 = v.PhoneNumber1,
            PhoneNumber2 = v.PhoneNumber2,
            VendorWalletAmount = v.VendorWalletAmount
        }).ToListAsync();
    }

    public async Task<VendorDTO> UpdateVendor(UpdateVendorRequest request)
    {
        var vendor = context.Vendors.FirstOrDefault(v => v.Id == request.Id);
        if (vendor == null)
            throw new Exception($"Vendor id {request.Id} not found");

        vendor.Code = request.Code;
        vendor.Name = request.Name;
        vendor.BrandName = request.BrandName;
        vendor.PhoneNumber1 = request.PhoneNumber1;
        vendor.PhoneNumber2 = request.PhoneNumber2;

        await context.SaveChangesAsync();

        return new VendorDTO
        {
            Id = vendor.Id,
            Code = vendor.Code,
            Name = vendor.Name,
            BrandName = vendor.BrandName,
            PhoneNumber1 = vendor.PhoneNumber1,
            PhoneNumber2 = vendor.PhoneNumber2,
            VendorWalletAmount = vendor.VendorWalletAmount
        };
    }
}
