namespace Inheritance.Second;

public class Rectangle(float a, float b, float c, float d) : ITetragon
{
    public float _a = a;
    public float _b = b;
    public float _c = c;
    public float _d = d;
    
    public float CountPerimeter()
    {
        return _a + _b + _c + _d;
    }

    public float CountArea()
    {
        return _a * _b;
    }
}