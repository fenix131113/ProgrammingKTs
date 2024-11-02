namespace UML_PATTERNS_KT.Singleton;

public class PlayerData(int money, int level)
{
    private static PlayerData? _instance;

    public static PlayerData Instance
    {
        get { return _instance ??= new PlayerData(0, 0); }
    }

    public int Money { get; private set; } = money;
    public int Level { get; private set; } = level;

    public void SetMoney(int money) => Money = money;
    public void SetLevel(int level) => Level = level;
}