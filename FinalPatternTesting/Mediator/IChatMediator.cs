namespace FinalPatternTesting.Mediator;

public interface IChatMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, User sender);
}