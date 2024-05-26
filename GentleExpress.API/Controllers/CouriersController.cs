using GentleExpress.Models.Couriers;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CouriersController(ICourierService courierService) : ControllerBase
{
    [HttpGet]
    public Task<List<CourierDTO>> Get() => courierService.GetCouriers();

    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
