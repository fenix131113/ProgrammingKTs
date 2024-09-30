namespace Generic_boxing_unboxing.Boxing_Unboxing
{
	public class BoxingUnboxingEntry
	{
		public void CompleteTask()
		{
			Console.WriteLine($"\n-------{GetType().Name}-------");
			var objects = new List<object>();
			FillArray(objects, 5);
			Console.WriteLine($"Sum is {GetArraySum(objects)}");
		}

		private static void FillArray(List<object> objects, int count)
		{
			for (var i = 0; i < count; i++)
			{
				if (Random.Shared.Next(0, 2) == 0)
					objects.Add(Random.Shared.NextSingle());
				else
					objects.Add(Random.Shared.Next(1, 6));
			}
		}

		private float GetArraySum(List<object> objects)
		{
			float sum = 0;
			foreach (var item in objects)
			{
				if (int.TryParse(item.ToString(), out var resultInt))
					sum += resultInt;
				else if (float.TryParse(item.ToString(), out var resultFloat))
					sum += resultFloat;
				else
					Console.WriteLine($"[{GetType().Name}] There is no float or int!");
			}

			return sum;
		}
	}
}