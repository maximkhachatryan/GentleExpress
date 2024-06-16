using GentleExpress.Models.Orders;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(IDeliveriesService deliveriesService) : ControllerBase
{
    [HttpPost]
    public Task<OrderDTO> PlaceOrder(PlaceOrderRequest request)
        => deliveriesService.PlaceOrder(request);
}
