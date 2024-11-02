namespace UML_PATTERNS_KT.Prototype;

public abstract class Prototype(int id)
{
    public int ID { get; private set; } = id;
    
    public abstract Prototype Clone();
}