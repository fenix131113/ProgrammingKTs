namespace UML_PATTERNS_KT.Prototype;

public class ShootEnemy(int id, int damage, int level, float maxDistance) : Prototype(id)
{
    public int Damage { get; private set; } = damage;
    public int Level { get; private set; } = level;
    public float MaxDistance { get; private set; } = maxDistance;

    public override Prototype Clone() => new ShootEnemy(ID, Damage, Level, MaxDistance);
    public override string ToString() => $"Damage: {Damage}, Level: {Level}, MaxDistance: {MaxDistance}";
}