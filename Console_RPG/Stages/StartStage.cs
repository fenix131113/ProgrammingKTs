namespace Console_RPG.Stages;

public static class StartStage
{
    public static void Run()
    {
        AskForHero();
    }

    private static void AskForHero()
    {
        Console.WriteLine("Choose your hero: Warrior, Wizard, Archer");

        var input = Console.ReadLine()?.ToLower();
        while (input is not ("warrior" or "wizard" or "archer"))
        {
            Console.WriteLine("Invalid warrior, you need to choose on of: Warrior, Wizard, Archer");
            input = Console.ReadLine()?.ToLower();
        }

        switch (input)
        {
            case "warrior":
                PlayerData.SetHero(new Hero("Warrior", 120, 30, 0.15f));
                break;
            case "wizard":
                PlayerData.SetHero(new Hero("Wizard", 80, 40, 0.3f));
                break;
            case "archer":
                PlayerData.SetHero(new Hero("Archer", 90, 40, 0.2f));
                break;
        }

        Console.WriteLine(
            $"You chose {input}, your health = {PlayerData.Hero.Health}, your damage = {PlayerData.Hero.Damage}, your critical = {PlayerData.Hero.CriticalDamageChance}");
    }
}