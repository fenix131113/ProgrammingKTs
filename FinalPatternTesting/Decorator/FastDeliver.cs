namespace FinalPatternTesting.Decorator;

public class FastDeliver : BaseOrder
{
    public FastDeliver(BaseOrder order)
    {
        Cost = order.Cost + 30;
        Description = order.Description + "\n" + "Fast Deliver";
    }
}