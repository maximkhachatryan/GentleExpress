﻿using GentleExpress.Models.Couriers;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;


namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CouriersController(ICouriersService couriersService) : ControllerBase
{
    [HttpGet]
    public Task<List<CourierDTO>> Get() => couriersService.GetCouriers();

}
