using Core.Model;
using Core.Persistence;

namespace Persistence;

public class GreetingsRepository : IGreetingsRepository
{
    public Greeting FetchGreeting()
    {
        return new Greeting { Text = "Hello, World!!!" };
    }
}
