namespace FinalPatternTesting.Decorator;

public class BaseOrder : IOrder
{
    public int Cost { get; protected set; } = 100;
    public string Description { get; protected set; } = "Base order";

    public int GetPrice()
    {
        return Cost;
    }

    public string GetDescription()
    {
        return Description;
    }
}