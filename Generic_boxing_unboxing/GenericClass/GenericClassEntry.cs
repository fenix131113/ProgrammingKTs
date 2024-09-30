namespace Generic_boxing_unboxing.GenericClass
{
	public class GenericClassEntry
	{
		public void CompleteTask()
		{
			Console.WriteLine($"\n-------{GetType().Name}-------");

			var book1 = new Book<string>("test", "Book #1", 315, "TestAuthor");
			var book2 = new Book<string>("test2", "Book #2", 643, "TestAuthor2");
			var book3 = new Book<string>("test3", "Book #3", 86, "TestAuthor3");
			var book4 = new Book<int>(4, "Book #4", 7534, "TestAuthor4");
			var book5 = new Book<int>(5, "Book #5", 6666, "TestAuthor5");
			var book6 = new Book<int>(6, "Book #6", 1111, "TestAuthor6");
			var book7 = new Book<Guid>(Guid.NewGuid(), "Book #7", 9845, "Guid Author");
			var book8 = new Book<Guid>(Guid.NewGuid(), "Book #8", 369, "Guid Author 2");
			var book9 = new Book<Guid>(Guid.NewGuid(), "Book #9", 526, "Guid Author 3");
			
			Console.WriteLine(book1.ToString());
			Console.WriteLine(book2.ToString());
			Console.WriteLine(book3.ToString());
			Console.WriteLine(book4.ToString());
			Console.WriteLine(book5.ToString());
			Console.WriteLine(book6.ToString());
			Console.WriteLine(book7.ToString());
			Console.WriteLine(book8.ToString());
			Console.WriteLine(book9.ToString());
		}
	}
}