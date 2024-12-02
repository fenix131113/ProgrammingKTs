namespace Console_RPG;

public static class PlayerData
{
    public static Hero Hero { get; private set; }

    public static void SetHero(Hero hero)
    {
        if (Hero == null)
            Hero = hero;
    }
}