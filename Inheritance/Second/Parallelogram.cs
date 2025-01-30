namespace Inheritance.Second;

public class Parallelogram(float a, float b, float c, float d, float angle) : ITetragon
{
    public float _a = a;
    public float _b = b;
    public float _c = c;
    public float _d = d;
    public float _angle = angle;
    
    public float CountPerimeter()
    {
        return _a + _b + _c + _d;
    }

    public float CountArea()
    {
        return a * b * (float)Math.Sin(_angle);
    }
}