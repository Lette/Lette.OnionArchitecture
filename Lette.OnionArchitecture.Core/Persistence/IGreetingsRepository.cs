using Lette.OnionArchitecture.Core.Model;

namespace Lette.OnionArchitecture.Core.Persistence;

public interface IGreetingsRepository
{
    Greeting FetchGreeting();
}
