using UML_PATTERNS_KT.Builder;
using UML_PATTERNS_KT.Factory;
using UML_PATTERNS_KT.Prototype;
using UML_PATTERNS_KT.Singleton;

namespace UML_PATTERNS_KT;

class Program
{
    static void Main()
    {
        var singleton = new SingletonUse();
        singleton.Run();
        
        Console.WriteLine("-------------------");

        var prototype = new PrototypeUse();
        prototype.Run();
        
        Console.WriteLine("-------------------");

        var factory = new FactoryUse();
        factory.Run();
        
        Console.WriteLine("-------------------");

        var builder = new BuilderUse();
        builder.Run();
    }
}