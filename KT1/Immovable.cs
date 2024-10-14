namespace KT1;

public class Immovable(float worth, float area) : Property(worth)
{
	protected float _area = area;

	public override float Tax()
	{
		return _area switch
		{
			< 100 => worth / 500f,
			> 100 and < 300 => worth / 350f,
			_ => worth / 250f
		};
	}

	public float MetreCost() => worth / area;

	public override string ToString() => $"{GetType().Name}: Cost - {worth},Tax - {Tax()}, Area - {area} sq.m, Cost per metre - {MetreCost()}";
}