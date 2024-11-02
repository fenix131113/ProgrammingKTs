namespace UML_PATTERNS_KT.Factory;

public class MercedesCar : CarProduct
{
    public MercedesCar(int strength) : base(strength)
    {
        Console.WriteLine($"Mercedes Car Created! Strength: {Strength}");
    }   
}