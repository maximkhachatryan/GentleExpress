using GentleExpress.Models.Districts;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class DistrictsService(GentleExpressPostgresDbContext context) : IDistrictsService
{
    public Task<List<DistrictDTO>> GetDistrictsByCityId(int cityId)
    {
        return context.Districts.Where(d => d.CityId == cityId)
            .Select(c =>
                new DistrictDTO
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
    }
}
