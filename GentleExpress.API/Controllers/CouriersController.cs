﻿using GentleExpress.Models.Couriers;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CouriersController(ICouriersService courierService) : ControllerBase
{
    [HttpGet]
    public Task<List<CourierDTO>> Get() => courierService.GetCouriers();

}
