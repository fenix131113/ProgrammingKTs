namespace FinalPatternTesting.Decorator;

public class AdditionalDrinks : BaseOrder
{
    public AdditionalDrinks(BaseOrder order)
    {
        Cost = order.Cost + 50;
        Description = order.Description + "\n" + "Additional Drinks";
    }
}