using KeyedServiceExample.Api.Interfaces;

namespace KeyedServiceExample.Api.Services;

public class ServiceA : IService
{
    public string DoSomething() => "Hello I am the service A";
}