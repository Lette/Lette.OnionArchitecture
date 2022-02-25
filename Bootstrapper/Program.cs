using Bootstrapper;
using Core.Controllers;
using Persistence;
using Presentation;

IApp app = new App(
    new HelloWorldController(
        new GreetingsRepository(),
        new GreetingsPresenter()
    )
);

app.Run();
