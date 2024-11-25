namespace FinalPatternTesting.Mediator;

public class MediatorUse
{
    public void Use()
    {
        var chat = new Chat();
        var user1 = new User(chat);
        var user2 = new User(chat);
        var user3 = new User(chat);
        var user4 = new User(chat);
        
        user1.Send("Hello");
        user2.Send("Hi");
        user3.Send("How are you?");
        user4.Send("Fine");
    }
}