namespace FinalPatternTesting.Mediator;

public class User : IChatMember
{
    private readonly Chat _chat;

    public User(Chat chat)
    {
        _chat = chat;
        _chat.RegisterUser(this);
    }
    
    public void Send(string message)
    {
        Console.WriteLine($"Message sent: {message}");
        _chat.SendMessage(message, this);
    }
    
    public void Notify(string message)
    {
        Console.WriteLine($"Message received: {message}");
    }
}