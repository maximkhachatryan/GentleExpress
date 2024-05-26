using GentleExpress.Models.Cities;
using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.Services.EFCore.Services;

public class CitiesService(GentleExpressPostgresDbContext context)
    : ICitiesService
{
    public Task<List<CityDTO>> GetCities()
    {
        return context.Cities.Select(c =>
            new CityDTO
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
    }
}
