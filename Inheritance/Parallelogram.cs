namespace Inheritance;

public class Parallelogram(float a, float b, float c, float d, float angle) : Tetragon(a, b, c, d, angle)
{
    public override float CountArea()
    {
        return a * b * (float)Math.Sin(_angle);
    }
}