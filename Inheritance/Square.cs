namespace Inheritance;

public class Square(float a) : Tetragon(a, a, a, a, 0)
{
    public override float CountArea()
    {
        return _a * _a;
    }
}