namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new Tetragon(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Tetragon(2, 2 ,2, 2, 15).CountPerimeter());
        Console.WriteLine(new Parallelogram(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Parallelogram(2, 2 ,2, 2, 15).CountPerimeter());
        Console.WriteLine(new Rectangle(2, 2 ,2, 2).CountArea());
        Console.WriteLine(new Rectangle(2, 2 ,2, 2).CountPerimeter());
        Console.WriteLine(new Rhomb(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Rhomb(2, 2 ,2, 2, 15).CountPerimeter());
        Console.WriteLine(new Square(2).CountArea());
        Console.WriteLine(new Square(2).CountPerimeter());
        Console.WriteLine(new ConvexQuadrilateral(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new ConvexQuadrilateral(2, 2 ,2, 2, 15).CountPerimeter());
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine(new Second.Parallelogram(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Second.Parallelogram(2, 2 ,2, 2, 15).CountPerimeter());
        Console.WriteLine(new Second.Rectangle(2, 2 ,2, 2).CountArea());
        Console.WriteLine(new Second.Rectangle(2, 2 ,2, 2).CountPerimeter());
        Console.WriteLine(new Second.Rhomb(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Second.Rhomb(2, 2 ,2, 2, 15).CountPerimeter());
        Console.WriteLine(new Second.Square(2, 2 ,2, 2).CountArea());
        Console.WriteLine(new Second.Square(2, 2 ,2, 2).CountPerimeter());
        Console.WriteLine(new Second.ConvexQuadrilateral(2, 2 ,2, 2, 15).CountArea());
        Console.WriteLine(new Second.ConvexQuadrilateral(2, 2 ,2, 2, 15).CountPerimeter());
    }
}
