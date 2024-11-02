namespace UML_PATTERNS_KT.Factory;

public class FactoryUse
{
    public void Run()
    {
        var mercedesCreator = new MercedesCarFactory();
        var mercedes = mercedesCreator.Create();
        Console.WriteLine(mercedes.Strength);

        var bmvCreator = new BmvCarFactory();
        var bmv = bmvCreator.Create();
        Console.WriteLine(bmv.Strength);
    }
}