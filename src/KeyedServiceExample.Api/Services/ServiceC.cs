using KeyedServiceExample.Api.Interfaces;

namespace KeyedServiceExample.Api.Services;

public class ServiceC([FromKeyedServices("service-b")] IService _service) : IService
{
    public string DoSomething() => $"Hello I am the service C whit " + _service.DoSomething();
}