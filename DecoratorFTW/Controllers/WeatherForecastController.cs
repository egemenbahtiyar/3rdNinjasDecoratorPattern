using DecoratorFTW.Factories;
using DecoratorFTW.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorFTW.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IHelloService _helloService;
    private readonly IEnumerable<IGreetingService> _greetingServices;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IHelloServiceFactory helloServiceFactory, IEnumerable<IGreetingService> greetingServices)
    {
        _logger = logger;
        _greetingServices = greetingServices;
        _helloService = helloServiceFactory.CreateHelloService(HelloServiceType.One);
    }

    [HttpGet]
    public string Test()
    {
        var greetingServiceOne = _greetingServices.First(x => x.Execute("GreetingServiceOne"));

       return greetingServiceOne.Greetings();
    }
}