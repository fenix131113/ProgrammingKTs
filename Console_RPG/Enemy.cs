namespace Console_RPG;

public class Enemy(int damage, int health)
{
    public int Damage { get; private set; } = damage;
    public int Health { get; private set; } = health;

    /// <returns>True if enemy is dead</returns>
    public bool TakeDamage(int dmg)
    {
        Health -= dmg;
        return Health <= 0;
    }
}