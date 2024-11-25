namespace FinalPatternTesting.State;

public class ChooseDrinkState : ICoffeeMachineState
{
    public void TakeCoin()
    {
        Console.WriteLine("Coin already taken...");
    }

    public void SelectDrink()
    {
        Console.WriteLine("Drink selected...");
    }

    public void Dispense()
    {
        Console.WriteLine("Need to select drink...");
    }
}