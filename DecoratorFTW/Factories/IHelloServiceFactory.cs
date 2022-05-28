using DecoratorFTW.Services;
using DecoratorFTW.Services.Contracts;

namespace DecoratorFTW.Factories;

public interface IHelloServiceFactory
{
    IHelloService CreateHelloService(HelloServiceType serviceType);
}

public enum HelloServiceType
{
    One,
    Two
}

public class HelloServiceFactory: IHelloServiceFactory
{
    public IHelloService CreateHelloService(HelloServiceType serviceType)
    {
        
        if (serviceType == HelloServiceType.One)
        {
            return new HelloServiceOne();
        }
        else
        {
            return new HelloServiceTwo();
        }
    }
}