namespace SmartHouseKT;

public class MusicStation
{
    public bool IsTurnedOn { get; private set; }
    public string? Music { get; private set; }
    
    public override string ToString()
    {
        return $"State: {IsTurnedOn}, Music: {Music}";
    }
    
    public void Switch(bool state) => IsTurnedOn = state;
    public void SetMusic(string music) => Music = music;
}