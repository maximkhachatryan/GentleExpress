using GentleExpress.Models.Vendors;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class VendorsService(GentleExpressPostgresDbContext context)
    : IVendorsService
{
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
}
