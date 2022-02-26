using Lette.OnionArchitecture.Core.Model;
using Lette.OnionArchitecture.Core.Persistence;

namespace Lette.OnionArchitecture.Persistence;

public class GreetingsRepository : IGreetingsRepository
{
    public Greeting FetchGreeting()
    {
        return new Greeting { Text = "Hello, World!!!" };
    }
}
