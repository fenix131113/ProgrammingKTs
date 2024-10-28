namespace Pattern_KT1;

class Program
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out var result))
        {
            var builder = new LevelBuilder();
            builder.BuildLevel(result);
            
            if (builder.Level == null) return;
            
            Console.WriteLine(builder.Level.Enemies.Count);
            foreach (var enemy in builder.Level.Enemies)
                Console.WriteLine(enemy.EnemyType);
        }
        else
            Console.WriteLine("Enter valid number!");
    }
}