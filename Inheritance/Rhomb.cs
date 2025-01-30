namespace Inheritance;

public class Rhomb(float a, float b, float c, float d, float angle) : Tetragon(a, b, c, d, angle)
{
    public override float CountArea()
    {
        return a * 2 * (float)Math.Sin(_angle);
    }
}