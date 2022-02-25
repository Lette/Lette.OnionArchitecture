using Core.Model;
using Core.Presentation;

namespace Presentation;

public class GreetingsPresenter : IGreetingsPresenter
{
    public void Show(Greeting greeting)
    {
        Console.WriteLine(greeting.Text);
    }
}
