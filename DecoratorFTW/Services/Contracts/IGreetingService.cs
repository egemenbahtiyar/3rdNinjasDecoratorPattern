namespace DecoratorFTW.Services.Contracts;

public interface IGreetingService
{
    bool Execute(string flag);
    string Greetings();
}

public class GreetingServiceOne : IGreetingService
{
    public bool Execute(string flag)
    {
        if (flag == "GreetingServiceTwo")
        {
            return true;
        }

        return false;
    }

    public string Greetings()
    {
        return "Hello from Greetings service 1";
    }
}

public class GreetingServiceTwo : IGreetingService
{
    public bool Execute(string flag)
    {
        if (flag == "GreetingServiceOne")
        {
            return true;
        }

        return false;
    }

    public string Greetings()
    {
        return "Hello from service 2";
    }
}