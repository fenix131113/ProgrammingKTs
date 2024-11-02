namespace UML_PATTERNS_KT.Singleton;

public class SingletonUse
{
    public void Run()
    {
        Console.WriteLine(PlayerData.Instance.Money);
        Console.WriteLine(PlayerData.Instance.Level);
        PlayerData.Instance.SetMoney(599);
        PlayerData.Instance.SetLevel(23);
        Console.WriteLine(PlayerData.Instance.Money);
        Console.WriteLine(PlayerData.Instance.Level);
    }
}