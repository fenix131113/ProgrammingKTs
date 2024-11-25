namespace FinalPatternTesting.Decorator;

public class DecoratorUse
{
    public void Use()
    {
        BaseOrder order1 = new();
        order1 = new AdditionalDrinks(order1);
        Console.WriteLine($"Cost: {order1.Cost} | Description: {order1.Description}");
        order1 = new PresentPack(order1);
        Console.WriteLine($"Cost: {order1.Cost} | Description: {order1.Description}");
        order1 = new FastDeliver(order1);
        Console.WriteLine($"Cost: {order1.Cost} | Description: {order1.Description}");
    }
}