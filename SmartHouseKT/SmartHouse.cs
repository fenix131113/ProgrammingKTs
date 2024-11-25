using System.Drawing;

namespace SmartHouseKT;

public class SmartHouse
{
    private Light _light = new();
    private TV _tv = new();
    private AirConditioner _airConditioner = new();
    private MusicStation _musicStation = new();
    
    public void SetUpHome(CommandType commandType)
    {
        switch (commandType)
        {
            case CommandType.PARTY:
                _light.SwitchLight(true);
                _light.ChangeBrightness(100);
                _light.ChangeColor(Color.Red);
                _tv.SwitchTV(true);
                _tv.TurnOnProgram("Party program");
                _airConditioner.Switch(true);
                _airConditioner.SetTemperature(24);
                _musicStation.Switch(true);
                _musicStation.SetMusic("Party music");
                break;
            case CommandType.GOOD_MORNING:
                _light.SwitchLight(false);
                _light.ChangeColor(Color.Green);
                _airConditioner.Switch(true);
                _airConditioner.SetTemperature(19);
                _musicStation.Switch(true);
                _musicStation.SetMusic("Morning music");
                break;
            case CommandType.COLLEGE:
                _light.SwitchLight(true);
                _light.ChangeBrightness(100);
                _light.ChangeColor(Color.White);
                _tv.SwitchTV(false);
                _airConditioner.Switch(false);
                _musicStation.Switch(false);
                break;
            case CommandType.AWAY:
                _light.SwitchLight(false);
                _tv.SwitchTV(false);
                _airConditioner.Switch(false);
                _musicStation.Switch(false);
                break;
            case CommandType.HOME_ALONE:
                _light.SwitchLight(true);
                _light.ChangeBrightness(50);
                _light.ChangeColor(Color.Green);
                _tv.SwitchTV(false);
                _airConditioner.Switch(true);
                _airConditioner.SetTemperature(24);
                _musicStation.Switch(true);
                _musicStation.SetMusic("Favorite music");
                break;
        }
        
        Console.WriteLine(_light.ToString());
        Console.WriteLine(_tv.ToString());
        Console.WriteLine(_airConditioner.ToString());
        Console.WriteLine(_musicStation.ToString());
    }

    public enum CommandType
    {
        PARTY,
        GOOD_MORNING,
        COLLEGE,
        AWAY,
        HOME_ALONE
    }
}