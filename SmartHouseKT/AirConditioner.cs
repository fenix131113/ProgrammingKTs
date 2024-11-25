namespace SmartHouseKT;

public class AirConditioner
{
    public bool IsTurnedOn { get; private set; }
    public int Temperature { get; private set; }
    
    public override string ToString()
    {
        return $"State: {IsTurnedOn}, Temperature: {Temperature}";
    }

    public void Switch(bool state) => IsTurnedOn = state;
    public void SetTemperature(int temperature) => Temperature = temperature;
}