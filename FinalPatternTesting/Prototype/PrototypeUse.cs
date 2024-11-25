namespace FinalPatternTesting.Prototype;

public class PrototypeUse
{
    public void Use()
    {
        var cube1 = new Cube(0, 0, 15, 15);
        var cube2 = cube1.Clone();
        var cube3 = cube1.Clone();
        
        cube2.SetX(2);
        cube2.SetY(2);
        cube2.SetSize(10);
        cube2.SetColorID(1);
        
        cube3.SetX(3);
        cube3.SetY(3);
        cube3.SetSize(33);
        cube3.SetColorID(3);
        
        Console.WriteLine(cube1.ToString());
        Console.WriteLine(cube2.ToString());
        Console.WriteLine(cube3.ToString());
        
        var sphere1 = new Sphere(2.5f, 13, 15);
        var sphere2 = sphere1.Clone();
        var sphere3 = sphere1.Clone();
        
        sphere2.SetSize(20);
        sphere2.SetRadius(12.1f);
        sphere2.SetColorID(9);
        
        sphere3.SetSize(33);
        sphere3.SetRadius(35.3f);
        sphere3.SetColorID(31);
        
        Console.WriteLine(sphere1.ToString());
        Console.WriteLine(sphere2.ToString());
        Console.WriteLine(sphere3.ToString());
    }
}