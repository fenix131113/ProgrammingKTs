namespace FinalPatternTesting.Proxy;

public class RealService : IService
{
    public string GetData()
    {
        return Task.Run(LoadData).Result;
    }

    private Task<string> LoadData()
    {
        Task.Delay(3000).Wait();
        
        return Task.FromResult("Data from server");
    }
}