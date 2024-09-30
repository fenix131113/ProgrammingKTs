using Generic_boxing_unboxing.GenericClass;

namespace Generic_boxing_unboxing.DefaultValues
{
	public class DefaultValuesEntry
	{
		public void CompleteTask()
		{
			Console.WriteLine($"\n-------{GetType().Name}-------");

			var intValue = new DefaultValuesClass<int>(5);
			var bookValue = new DefaultValuesClass<Book<int>>(new Book<int>(5, "test name", 314, "test author"));
			
			Console.WriteLine(intValue.Value);
			Console.WriteLine(bookValue.Value);
			
			intValue.Reset();
			bookValue.Reset();
			
			Console.WriteLine("Int value = " + intValue.Value);
			Console.WriteLine("Book value = " + bookValue.Value);
		}
	}
}