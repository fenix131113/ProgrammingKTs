namespace FinalPatternTesting.State;

public interface ICoffeeMachineState
{
    void TakeCoin();
    void SelectDrink();
    void Dispense();
}