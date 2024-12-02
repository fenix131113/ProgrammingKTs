namespace Console_RPG;

public class Hero(string name, float health, int damage, float criticalDamageChance)
{
    public const int EXPERIENCE_FOR_NEW_LEVEL = 1000;

    public string Name { get; private set; } = name;
    public float Health { get; private set; } = health;
    public float MaxHealth { get; private set; } = health;
    public int Damage { get; private set; } = damage;
    public float CriticalDamageChance { get; private set; } = criticalDamageChance;
    public int Experience { get; private set; }
    public int Level { get; private set; } = 1;
    public int HealAbilitiesLeft { get; private set; } = 10;
    public int KilledEnemyCount { get; private set; }

    public void TakeDamage(int damage) => Health = Math.Clamp(Health - damage, 0, MaxHealth);
    public void OnEnemyKilled() => KilledEnemyCount++;
    
    public void AddExperience(int experience) => Experience += experience;

    public void Heal()
    {
        if (HealAbilitiesLeft == 0)
            return;

        Health = Math.Clamp(Health + 50, 0, MaxHealth);
        HealAbilitiesLeft--;
    }

    public string LevelUp(string upgradeLabel)
    {
        var result = "";
        
        switch (upgradeLabel)
        {
            case "damage":
                Damage += 5;
                result = $"You successfully upgrade damage, now it's: {Damage}!";
                break;
            case "health":
                MaxHealth += 25;
                Health += 25;
                result = $"You successfully upgrade max health, now it's: {MaxHealth}!";
                break;
            case "critical":
                CriticalDamageChance += 0.05f;
                result = $"You successfully critical chance, now it's: {CriticalDamageChance}!";
                break;
        }
        
        Experience -= EXPERIENCE_FOR_NEW_LEVEL;
        Level++;

        return result;
    }
}