namespace Inheritance;

public class Tetragon(float a, float b, float c, float d, float angle)
{
    public float _a = a;
    public float _b = b;
    public float _c = c;
    public float _d = d;
    public float _angle = angle;

    public virtual float CountPerimeter()
    {
        return _a + _b + _c + _d;
    }

    public virtual float CountArea()
    {
        return _a * _b;
    }
}