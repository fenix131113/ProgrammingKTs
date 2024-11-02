namespace UML_PATTERNS_KT.Prototype;

public class PrototypeUse
{
    public void Run()
    {
        Prototype prototype = new MeleeEnemy(0, 15, 1);
        var clone = prototype.Clone();
        Console.WriteLine(clone.ToString());
        
        Prototype prototype2 = new ShootEnemy(1, 25, 3, 5.99f);
        var clone2 = prototype2.Clone();
        Console.WriteLine(clone2.ToString());
    }
}