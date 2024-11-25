namespace FinalPatternTesting.State;

public class CoffeeMachine
{
    private ICoffeeMachineState _state = new CoinWaitingState();

    public void InsertCoin()
    {
        _state.TakeCoin();

        if (_state.GetType() == typeof(CoinWaitingState))
            _state = new ChooseDrinkState();
    }

    public void SelectDrink()
    {
        _state.SelectDrink();

        if (_state.GetType() == typeof(ChooseDrinkState))
            _state = new DispenseDrinkState();

        DispenseDrink();
    }

    public void DispenseDrink()
    {
        _state.Dispense();

        if (_state.GetType() == typeof(DispenseDrinkState))
            _state = new CoinWaitingState();
    }
}