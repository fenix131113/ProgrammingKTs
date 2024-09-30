using System.Numerics;

namespace Generic_boxing_unboxing.SeveralGenericTypes;

public class SeveralGenericTypesEntry
{
	public void CompleteTask()
	{
		Console.WriteLine($"\n-------{GetType().Name}-------");
		
		var rectange1 = new Rectangle<string, int>(new Vector2(0, 0), "4", 2);
		var rectange2 = new Rectangle<float, double>(new Vector2(1.5f, 2.5f), 2.5f, 3.3);
		var rectange3 = new Rectangle<string, float>(new Vector2(-2, 3), "3", 4.2f);
		
		Console.WriteLine($"{rectange1.MinPivot} - {rectange1.MaxPivot}");
		Console.WriteLine($"{rectange2.MinPivot} - {rectange2.MaxPivot}");
		Console.WriteLine($"{rectange3.MinPivot} - {rectange3.MaxPivot}");
	}
}