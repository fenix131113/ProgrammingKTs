namespace FinalPatternTesting.Prototype;

public interface IPrototype<out T>
{
    T Clone();
}