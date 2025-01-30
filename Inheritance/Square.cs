namespace Inheritance;

public class Square(float a, float b, float c, float d, float angle) : Tetragon(a, b, c, d, angle)
{
    public override float CountArea()
    {
        return a * a;
    }
}