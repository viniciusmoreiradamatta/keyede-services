using KeyedServiceExample.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServiceExample.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController([FromKeyedServices("service-a")] IService _serviceA,
                                       [FromKeyedServices("service-b")] IService _serviceB ,
                                       [FromKeyedServices("service-c")] IService _serviceC 
    ) : ControllerBase
{
    [HttpGet("service-a")]
    public IActionResult GetA()
    {
        return Ok(_serviceA.DoSomething());
    }

    [HttpGet("service-b")]
    public IActionResult GetB()
    {
        return Ok(_serviceB.DoSomething());
    }

    [HttpGet("service-c")]
    public IActionResult GetC()
    {
        return Ok(_serviceC.DoSomething());
    }
}