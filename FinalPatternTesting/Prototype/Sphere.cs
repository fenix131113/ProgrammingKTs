namespace FinalPatternTesting.Prototype;

public class Sphere : IPrototype<Sphere>
{
    public float Radius { get; private set; }
    public float Size { get; private set; }
    public int ColorID { get; private set; }

    public Sphere(float radius, float size, int colorID)
    {
        Radius = radius;
        Size = size;
        ColorID = colorID;
    }
    
    public void SetRadius(float radius) => Radius = radius;
    public void SetSize(float size) => Size = size;
    public void SetColorID(int id) => ColorID = id;

    public Sphere Clone() => new(Radius, Size, ColorID);
    public override string ToString() => $"Radius: {Radius}, Size: {Size}, ColorID: {ColorID}";
}