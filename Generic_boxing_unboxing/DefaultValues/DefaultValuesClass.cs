namespace Generic_boxing_unboxing.DefaultValues;

public class DefaultValuesClass<T>(T? value)
{
	public T? Value { get; private set; } = value;

	public void Reset()
	{
		Value = default;
	}
}