namespace FinalPatternTesting.State;

public class StateUse
{
    public void Use()
    {
        var machine = new CoffeeMachine();
        machine.InsertCoin();
        machine.SelectDrink();
    }
}