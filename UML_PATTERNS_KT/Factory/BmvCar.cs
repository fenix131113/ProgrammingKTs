namespace UML_PATTERNS_KT.Factory;

public class BmvCar : CarProduct
{
    public BmvCar(int strength) : base(strength)
    {
        Console.WriteLine($"Bmv Car Created! Strength: {Strength}");
    }
}