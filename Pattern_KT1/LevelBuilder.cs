namespace Pattern_KT1;

public class LevelBuilder
{
    public Level? Level { get; private set; }

    public void BuildLevel(int difficulty)
    {
        var enemies = new List<Enemy>();

        switch (difficulty)
        {
            case 1:
                for (var i = 0; i < 5; i++)
                    enemies.Add(new Enemy("Bee"));
                break;
            case 2:
                for (var i = 0; i < 10; i++)
                {
                    enemies.Add(new Enemy("Bee"));
                    enemies.Add(new Enemy("Wolf"));
                }
                break;
            case 3:
                for (var i = 0; i < 15; i++)
                {
                    enemies.Add(new Enemy("Bee"));
                    enemies.Add(new Enemy("Wolf"));
                    enemies.Add(new Enemy("Bear"));
                }
                break;
            default:
                Console.WriteLine("This difficulty is not supported!");
                break;
        }

        Level = new Level(enemies);
    }
}