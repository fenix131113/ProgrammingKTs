namespace FinalPatternTesting.Decorator;

public class PresentPack : BaseOrder
{
    public PresentPack(BaseOrder order)
    {
        Cost = order.Cost + 20;
        Description = order.Description + "\n" + "Present Pack";
    }
}