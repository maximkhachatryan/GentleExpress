using GentleExpress.Models.Cities;
using GentleExpress.Services.Abstraction.Services;
using Microsoft.AspNetCore.Mvc;


namespace GentleExpress.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CitiesController(ICitiesService citiesService) : ControllerBase
{
    [HttpGet]
    public Task<List<CityDTO>> Get() => citiesService.GetCities();

}
