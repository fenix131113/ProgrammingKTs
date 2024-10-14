namespace KT1;

public class Vehicle(float worth, float volume) : Property(worth)
{
	protected readonly float _volume = volume;
	
	public override float Tax()
	{
		return _worth * _volume / 150000f;
	}
	
	public override string ToString() => $"{GetType().Name}: Cost - {_worth},Tax - {Tax()}, Volume - {_volume}cc.";
}