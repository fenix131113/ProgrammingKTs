namespace Generic_boxing_unboxing.GenericClass;

public class Book<T>(T id, string name, int pagesCount, string author)
{
	public T Id { get; private set; } = id;
	public string Name { get; private set; } = name;
	public int PagesCount { get; private set; } = pagesCount;
	public string Author{ get; private set; } = author;

	public override string ToString() => $"{Id?.ToString()} {Name}, {Author}, {PagesCount} страниц";
}