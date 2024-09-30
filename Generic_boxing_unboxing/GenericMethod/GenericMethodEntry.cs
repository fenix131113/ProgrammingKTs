using System.Numerics;

namespace Generic_boxing_unboxing.GenericMethod;

public class GenericMethodEntry
{
	public void CompleteTask()
	{
		Console.WriteLine($"\n-------{GetType().Name}-------");
		
		var circle1 = new Circle<int>(new Vector2(0, 0), 5);
		circle1.SetRadius(6);
		Console.WriteLine(circle1.Area);
		
		var circle2 = new Circle<string>(new Vector2(0, 0), "7");
		circle2.SetRadius("8");
		Console.WriteLine(circle2.Area);
		
		var circle3 = new Circle<double>(new Vector2(0, 0), 3.2);
		circle3.SetRadius(5.1);
		Console.WriteLine(circle3.Area);
		
		var circle4 = new Circle<float>(new Vector2(0, 0), 2.4f);
		circle4.SetRadius(4.3f);
		Console.WriteLine(circle4.Area);
	}
}