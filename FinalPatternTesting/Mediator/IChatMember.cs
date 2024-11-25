namespace FinalPatternTesting.Mediator;

public interface IChatMember
{
    void Send(string message);
    void Notify(string message);
}