using Console_RPG.Stages;

namespace Console_RPG;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        
        StartStage.Run();
        GameStage.Run();
    }
}