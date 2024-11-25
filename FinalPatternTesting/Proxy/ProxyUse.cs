namespace FinalPatternTesting.Proxy;

public class ProxyUse
{
    public void Use()
    {
        IService service = new ProxyService();
        Console.WriteLine(service.GetData());
    }
}