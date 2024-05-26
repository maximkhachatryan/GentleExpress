using GentleExpress.Models.Couriers;

namespace GentleExpress.Services.Abstraction.Services;

public interface ICouriersService
{
    Task<List<CourierDTO>> GetCouriers();
}
