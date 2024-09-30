using Generic_boxing_unboxing.Boxing_Unboxing;
using Generic_boxing_unboxing.DefaultValues;
using Generic_boxing_unboxing.GenericClass;
using Generic_boxing_unboxing.GenericMethod;
using Generic_boxing_unboxing.SeveralGenericTypes;

namespace Generic_boxing_unboxing
{

	internal static class Program
	{
		private static void Main()
		{
			var boxingEntry = new BoxingUnboxingEntry();
			boxingEntry.CompleteTask();

			var genericClassEntry = new GenericClassEntry();
			genericClassEntry.CompleteTask();

			var defaultValuesEntry = new DefaultValuesEntry();
			defaultValuesEntry.CompleteTask();
			
			var genericMethodEntry = new GenericMethodEntry();
			genericMethodEntry.CompleteTask();

			var severalGenericTypesEntry = new SeveralGenericTypesEntry();
			severalGenericTypesEntry.CompleteTask();
		}
	}
}