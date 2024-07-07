using GentleExpress.Models.Orders;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(IDeliveriesService deliveriesService) : ControllerBase
{
    [HttpPost]
    public Task<OrderDTO> PlaceOrder(PlaceOrderRequest request)
        => deliveriesService.PlaceOrder(request);

    [HttpPost("fill/{deliveryId}")]
    public Task FillOrder(int deliveryId, FillOrderRequest request)
        => deliveriesService.FillOrder(deliveryId, request);

    [HttpPost("accept/{deliveryId}")]
    public Task AcceptOrder(int deliveryId)
        => deliveriesService.AcceptOrder(deliveryId);

    [HttpPost("assignPickUpCourier/{deliveryId}/{courierId}")]
    public Task AssignPickUpCourier(int deliveryId, int courierId)
        => deliveriesService.AssignPickUpCourier(deliveryId, courierId);
}
