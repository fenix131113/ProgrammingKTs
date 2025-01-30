namespace Console_RPG.Stages;

public static class GameStage
{
    private static Enemy? _currentEnemy;

    public static void Run()
    {
        NextMove();
    }

    private static void NextMove()
    {
        if (PlayerData.Hero.Experience >= Hero.EXPERIENCE_FOR_NEW_LEVEL && _currentEnemy == null)
            NextUpgradeMove();
        else
            NextFightMove();
    }

    private static void NextFightMove()
    {
        Console.WriteLine();

        if (_currentEnemy == null)
        {
            _currentEnemy = new Enemy(Random.Shared.Next(10, 36), Random.Shared.Next(60, 96));

            Console.WriteLine($"Enemy:\nHealth = {_currentEnemy.Health}\nDamage = {_currentEnemy.Damage}");
        }

        Console.WriteLine(
            $"Write \"Attack\" to attack enemy or \"Heal\" to use heal, you have {PlayerData.Hero.HealAbilitiesLeft} healing abilities left.");

        var attackInput = Console.ReadLine()?.ToLower();

        while (attackInput is not ("attack" or "heal"))
        {
            Console.WriteLine("Invalid attack input! Try again...");
            attackInput = Console.ReadLine()?.ToLower();
        }

        switch (attackInput)
        {
            case "attack":
                EnemyTakesDamage();
                break;
            case "heal":
                PlayerData.Hero.Heal();
                
                Console.WriteLine($"You healed, now you have {PlayerData.Hero.Health} hp!" +
                                  $"You have {PlayerData.Hero.HealAbilitiesLeft} healing abilities left.");
                
                PlayerTakesDamage();
                break;
        }
    }

    private static void NextUpgradeMove()
    {
        Console.WriteLine($"You can upgrade! What you want to upgrade? Damage, Health, Critical");

        var upgradeInput = Console.ReadLine()?.ToLower();

        while (upgradeInput is not ("damage" or "health" or "critical"))
        {
            Console.WriteLine("Invalid attack input! Try again...");
            upgradeInput = Console.ReadLine()?.ToLower();
        }
        
        Console.WriteLine(PlayerData.Hero.LevelUp(upgradeInput));
        NextMove();
    }

    private static void EnemyTakesDamage()
    {
        Console.WriteLine();
        var critical = Random.Shared.NextSingle() < PlayerData.Hero.CriticalDamageChance;
        var finallyDamage = critical ? PlayerData.Hero.Damage * 2 : PlayerData.Hero.Damage;

        if (critical)
            Console.WriteLine("CRITICAL!");

        Console.WriteLine($"Damage you gave to enemy: {finallyDamage}");

        // If enemy is dead
        if (_currentEnemy!.TakeDamage(finallyDamage))
        {
            Console.WriteLine("You killed an enemy!");
            PlayerData.Hero.OnEnemyKilled();

            var giveExperience = Random.Shared.Next(200, 451);
            PlayerData.Hero.AddExperience(giveExperience);
            Console.WriteLine($"You received {giveExperience} experience! Now you have {PlayerData.Hero.Experience}/{Hero.EXPERIENCE_FOR_NEW_LEVEL}");
            
            _currentEnemy = null;
            

            //Check for winning condition
            if (PlayerData.Hero.KilledEnemyCount == 15)
            {
                WinStage.Run();
                return;
            }

            NextMove();
        }
        // If enemy still alive
        else
        {
            Console.WriteLine($"New enemy health: {_currentEnemy.Health}");
            PlayerTakesDamage();
        }
    }

    private static void PlayerTakesDamage()
    {
        Console.WriteLine();
        PlayerData.Hero.TakeDamage(_currentEnemy!.Damage);
        Console.WriteLine($"Enemy attacked you, his damage = {_currentEnemy.Damage}");

        // Check for player death
        if (PlayerData.Hero.Health == 0)
        {
            LoseStage.Run();
            return;
        }

        Console.WriteLine($"Your new health = {PlayerData.Hero.Health}");

        NextFightMove();
    }
}