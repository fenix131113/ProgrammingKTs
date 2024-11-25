namespace FinalPatternTesting.State;

public class CoinWaitingState : ICoffeeMachineState
{
    public void TakeCoin()
    {
        Console.WriteLine("Taking coin...");
    }

    public void SelectDrink()
    {
        Console.WriteLine("Need coin...");
    }

    public void Dispense()
    {
        Console.WriteLine("Need to Select drink...");
    }
}