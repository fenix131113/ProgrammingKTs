namespace Inheritance;

public class ConvexQuadrilateral(float a, float b, float c, float d, float angle) : Tetragon(a, b, c, d, angle)
{
    public override float CountArea()
    {
        return _a / 2 * _b * (float)Math.Sin(angle);
    }
}