namespace UML_PATTERNS_KT.Factory;

public class BmvCarFactory : CarFactory
{
    public override CarProduct Create() => new BmvCar(15);
}