namespace Pattern_KT1;

public class Enemy
{
    public string EnemyType { get; private set; }

    public Enemy(string type)
    {
        EnemyType = type;
    }
}