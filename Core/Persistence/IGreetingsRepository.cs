using Core.Model;

namespace Core.Persistence;

public interface IGreetingsRepository
{
    Greeting FetchGreeting();
}
