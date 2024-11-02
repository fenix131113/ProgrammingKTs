namespace UML_PATTERNS_KT.Factory;

public abstract class CarProduct(int strength)
{
    public int Strength { get; private set; } = strength;
}