namespace SmartHouseKT;

public class TV
{
    public bool IsTurnedOn { get; private set; }
    public string? Program { get; private set; }

    public override string ToString()
    {
        return $"State: {IsTurnedOn}, Program: {Program}";
    }

    public void SwitchTV(bool state) => IsTurnedOn = state;

    public void TurnOnProgram(string program) => Program = program;
}