using System.Drawing;

namespace SmartHouseKT;

public class Light
{
    public bool IsTurnedOn { get; private set; }
    public int Brightness { get; private set; }
    public Color Color { get; private set; }

    public override string ToString()
    {
        return $"State: {IsTurnedOn}, Brightness: {Brightness}, Color: {Color}";
    }

    public void SwitchLight(bool state) => IsTurnedOn = state;

    public void ChangeBrightness(int newBrightness) => Brightness = Math.Clamp(newBrightness, 0, int.MaxValue);

    public void ChangeColor(Color newColor) => Color = newColor;
}