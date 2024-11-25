namespace FinalPatternTesting.Proxy;

public class ProxyService : IService
{
    private string _cashedData = "";

    public string GetData()
    {
        return _cashedData == "" ? LoadData() : _cashedData;
    }

    private string LoadData()
    {
        var service = new RealService();
        _cashedData = service.GetData();
        return _cashedData;
    }
}