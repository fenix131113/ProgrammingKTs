using System.Numerics;
using Generic_boxing_unboxing.GenericMethod;

namespace Generic_boxing_unboxing.SeveralGenericTypes;

public class Rectangle<TWidth, THeight>(Vector2 center, TWidth width, THeight height) : Figure(center)
{
	public override Vector2 MinPivot => GetMinPivot();
	public override Vector2 MaxPivot => GetMaxPivot();

	private Vector2 GetMinPivot()
	{
		return Center - new Vector2(Convert.ToSingle(width) / 2, -Convert.ToSingle(height) / 2);
	}

	private Vector2 GetMaxPivot()
	{
		return Center + new Vector2(Convert.ToSingle(width) / 2, -Convert.ToSingle(height) / 2);
	}
}