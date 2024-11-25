namespace FinalPatternTesting.Mediator;

public class Chat : IChatMediator
{
    private List<User> _users = [];

    public void RegisterUser(User user)
    {
        if(_users.Contains(user))
            return;
        
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users.Where(user => user != sender))
            user.Notify(message);
    }
}