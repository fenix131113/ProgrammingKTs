namespace UML_PATTERNS_KT.Builder;

public abstract class TrainBuilder
{
    public Train Train { get; private set; } = new Train();
    
    public abstract void SetHeadWagon(int size);
    public abstract void SetCafeWagon(int size);
    public abstract void AddAdditionalWagon(int size);
}