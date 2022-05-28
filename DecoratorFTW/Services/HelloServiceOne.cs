using DecoratorFTW.Services.Contracts;

namespace DecoratorFTW.Services;

public class HelloServiceOne: IHelloService
{
    public string Hello()
    {
        return "Hello from service 1";
    }
}

public class HelloServiceTwo: IHelloService
{
    public string Hello()
    {
        
        return "Hello from service 2";
    }
}