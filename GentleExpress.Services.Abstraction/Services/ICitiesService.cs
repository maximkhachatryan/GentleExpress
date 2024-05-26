using GentleExpress.Models.Cities;
using GentleExpress.Models.Couriers;

namespace GentleExpress.Services.Abstraction.Services;

public interface ICitiesService
{
    Task<List<CityDTO>> GetCities();
}
