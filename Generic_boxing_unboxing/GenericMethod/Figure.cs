using System.Numerics;

namespace Generic_boxing_unboxing.GenericMethod;

public class Figure (Vector2 center)
{
	public Vector2 Center { get; protected set; } = center;
	public virtual Vector2 MinPivot { get;}
	public virtual Vector2 MaxPivot { get;}
}