namespace UML_PATTERNS_KT.Prototype;

public class MeleeEnemy(int id, int damage, int level) : Prototype(id)
{
    public int Damage { get; private set; } = damage;
    public int Level { get; private set; } = level;

    public override Prototype Clone() => new MeleeEnemy(ID, Damage, Level);
    public override string ToString() => $"Damage: {Damage}, Level: {Level}";
}