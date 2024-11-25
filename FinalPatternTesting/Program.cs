using FinalPatternTesting.Decorator;
using FinalPatternTesting.Mediator;
using FinalPatternTesting.Prototype;
using FinalPatternTesting.Proxy;
using FinalPatternTesting.State;

namespace FinalPatternTesting;

class Program
{
    static void Main()
    {
        var prototype = new PrototypeUse();
        prototype.Use();

        Console.WriteLine("\n--------------\n");
        
        var state = new StateUse();
        state.Use();
        
        Console.WriteLine("\n--------------\n");

        var mediator = new MediatorUse();
        mediator.Use();
                
        Console.WriteLine("\n--------------\n");

        var decorator = new DecoratorUse();
        decorator.Use();
                        
        Console.WriteLine("\n--------------\n");

        var proxy = new ProxyUse();
        proxy.Use();
    }
}