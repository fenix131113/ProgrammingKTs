namespace KT1;

internal class Program
{
	private static void Main(string[] args)
	{
		Property[] props =
		[
			new Apartment(5000000, 60), new Apartment(10000000, 95), new Apartment(15000000, 120),
			new Car(500000, 1900), new Car(1250000, 2350), new Car(15000000, 3000),
			new Boat(400000, 2666), new Boat(317000, 2450), new CountryHouse(25000000, 125),
			new CountryHouse(50000000, 176)
		];

		foreach (var prop in props) Console.WriteLine(prop);
	}
}