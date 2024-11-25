namespace FinalPatternTesting.State;

public class DispenseDrinkState : ICoffeeMachineState
{
    public void TakeCoin()
    {
        Console.WriteLine("Coin already taken...");
    }

    public void SelectDrink()
    {
        Console.WriteLine("Drink already selected...");
    }

    public void Dispense()
    {
        Console.WriteLine("Dispensing...");
    }
}