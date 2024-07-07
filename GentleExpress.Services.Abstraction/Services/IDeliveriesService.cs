using GentleExpress.Models.Orders;

namespace GentleExpress.Services.Abstraction.Services;

public interface IDeliveriesService
{
    Task<OrderDTO> PlaceOrder(PlaceOrderRequest request);
    Task FillOrder(int deliveryId, FillOrderRequest request);
    Task AcceptOrder(int deliveryId);
    Task AssignPickUpCourier(int deliveryId, int courierId);
}
