using Lette.OnionArchitecture.Core.Model;
using Lette.OnionArchitecture.Core.Presentation;

namespace Lette.OnionArchitecture.Presentation;

public class GreetingsPresenter : IGreetingsPresenter
{
    public void Show(Greeting greeting)
    {
        Console.WriteLine(greeting.Text);
    }
}
