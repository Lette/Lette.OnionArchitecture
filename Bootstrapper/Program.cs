using Lette.OnionArchitecture.Bootstrapper;
using Lette.OnionArchitecture.Core.Controllers;
using Lette.OnionArchitecture.Persistence;
using Lette.OnionArchitecture.Presentation;

IApp app = new App(
    new HelloWorldController(
        new GreetingsRepository(),
        new GreetingsPresenter()
    )
);

app.Run();
