using KeyedServiceExample.Api.Interfaces;

namespace KeyedServiceExample.Api.Services;

public class ServiceB : IService
{
    public string DoSomething() => "Hello I am the service B";
}