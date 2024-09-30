using System.Numerics;

namespace Generic_boxing_unboxing.GenericMethod;

public class Circle<T>(Vector2 center, T radius) : Figure(center)
{
	public T Radius { get; private set; } = radius;
	public double Area => Math.PI * Math.Pow(Convert.ToDouble(Radius), 2);

	public override Vector2 MinPivot => GetMinPivot();
	public override Vector2 MaxPivot => GetMaxPivot();

	private Vector2 GetMinPivot()
	{
		return center - new Vector2(Convert.ToSingle(radius), 0);
	}

	private Vector2 GetMaxPivot()
	{
		return center + new Vector2(Convert.ToSingle(radius), 0);
	}
	
	public void SetRadius(T radius)
	{
		Radius = radius;
	}
}