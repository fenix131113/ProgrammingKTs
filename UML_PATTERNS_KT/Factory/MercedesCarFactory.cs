namespace UML_PATTERNS_KT.Factory;

public class MercedesCarFactory : CarFactory
{
    public override CarProduct Create() => new MercedesCar(25);
}