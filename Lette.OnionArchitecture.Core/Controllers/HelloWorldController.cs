using Lette.OnionArchitecture.Core.Persistence;
using Lette.OnionArchitecture.Core.Presentation;

namespace Lette.OnionArchitecture.Core.Controllers;

public interface IHelloWorldController
{
    void ShowGreeting();
}

public class HelloWorldController : IHelloWorldController
{
    private readonly IGreetingsRepository _repository;
    private readonly IGreetingsPresenter _presenter;

    public HelloWorldController(IGreetingsRepository repository, IGreetingsPresenter presenter)
    {
        _repository = repository;
        _presenter = presenter;
    }

    public void ShowGreeting()
    {
        var greeting = _repository.FetchGreeting();

        _presenter.Show(greeting);
    }
}
