namespace KT1;

public abstract class Property(float worth)
{
	protected float _worth = worth;

	public abstract float Tax();
}