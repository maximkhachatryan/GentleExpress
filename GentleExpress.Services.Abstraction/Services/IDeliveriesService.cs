using GentleExpress.Models.Orders;

namespace GentleExpress.Services.Abstraction.Services;

public interface IDeliveriesService
{
    Task<OrderDTO> PlaceOrder(PlaceOrderRequest request);
}
