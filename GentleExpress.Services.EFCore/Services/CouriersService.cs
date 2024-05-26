using GentleExpress.Models.Couriers;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class CouriersService(GentleExpressPostgresDbContext context)
    : ICouriersService
{
    public Task<List<CourierDTO>> GetCouriers()
    {
        return context.Couriers.Select(c =>
            new CourierDTO
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName
            }).ToListAsync();
    }
}
