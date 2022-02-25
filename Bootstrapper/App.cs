using Core.Controllers;

namespace Bootstrapper;

public interface IApp
{
    void Run();
}

public class App : IApp
{
    private readonly IHelloWorldController _controller;

    public App(IHelloWorldController controller)
    {
        _controller = controller;
    }

    public void Run()
    {
        _controller.ShowGreeting();
    }
}
