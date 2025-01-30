namespace Inheritance;

public class Square(float a, float b, float c, float d) : Tetragon(a, b, c, d, 0)
{
    public override float CountArea()
    {
        return _a * _a;
    }
}