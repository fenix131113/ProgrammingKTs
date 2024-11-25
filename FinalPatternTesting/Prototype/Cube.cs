namespace FinalPatternTesting.Prototype;

public class Cube : IPrototype<Cube>
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Size { get; private set; }
    public int ColorID { get; private set; }

    public Cube(float x, float y, float size, int colorID)
    {
        X = x;
        Y = y;
        Size = size;
        ColorID = colorID;
    }

    public void SetX(float x) => X = x;
    public void SetY(float y) => Y = y;
    public void SetSize(float size) => Size = size;
    public void SetColorID(int id) => ColorID = id;

    public Cube Clone() => new(X, Y, Size, ColorID);
    public override string ToString() => $"X: {X}, Y: {Y}, Size: {Size}, ColorID: {ColorID}";
}