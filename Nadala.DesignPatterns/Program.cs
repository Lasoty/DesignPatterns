using Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using Nadala.DesignPatterns.BehavioralPatterns.Command;
using Nadala.DesignPatterns.BehavioralPatterns.Mediator;
using Nadala.DesignPatterns.BehavioralPatterns.State;
using Nadala.DesignPatterns.BehavioralPatterns.Strategy;
using Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;
using Nadala.DesignPatterns.CreationPatterns.Builder;
using Nadala.DesignPatterns.CreationPatterns.FactoryMethod;
using Nadala.DesignPatterns.CreationPatterns.Singleton.LazyInitialization;
using Nadala.DesignPatterns.CreationPatterns.Singleton.NonThreadSafe;
using Nadala.DesignPatterns.CreationPatterns.Singleton.ThreadSafe;
using Nadala.DesignPatterns.StructuralPatterns.Adapter;
using Nadala.DesignPatterns.StructuralPatterns.Bridge;
using Nadala.DesignPatterns.StructuralPatterns.Composite;
using Nadala.DesignPatterns.StructuralPatterns.Decorator;
using Nadala.DesignPatterns.StructuralPatterns.Facade;
using Nadala.DesignPatterns.StructuralPatterns.Flyweight;

namespace Nadala.DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            ShowMenu();
            int select = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (select)
            {
                case 1:
                    RunSingleton();
                    break;
                case 2:
                    FactoryMethodPattern.Run();
                    break;
                case 3:
                    AbstractFactoryPattern.Run();
                    break;
                case 4:
                    BuilderPattern.Run();
                    break;
                case 5:
                    AdapterPattern.Run();
                    break;
                case 6:
                    BridgePattern.Run();
                    break;
                case 7:
                    CompositePattern.Run();
                    break;
                case 8:
                    DecoratorPattern.Run();
                    break;
                case 9:
                    FacadePattern.Run();
                    break;
                case 10:
                    FlyweightPattern.Run();
                    break;
                case 11:
                    ChainOfResponsibilityPattern.Run();
                    break;
                case 12:
                    CommandPattern.Run();
                    break;
                case 13:
                    MediatorPattern.Run();
                    break;
                case 14:
                    StatePattern.Run();
                    break;
                case 15:
                    StrategyPattern.Run();
                    break;
            }

            Console.ReadLine();
        } while (true);
    }

    private static void RunSingleton()
    {
        Console.Clear();
        Console.WriteLine("1. Non Thread Safe");
        Console.WriteLine("2. Thread Safe");
        Console.WriteLine("3. Lazy Initialization");

        int select = int.Parse(Console.ReadLine());

        switch (select)
        {
            case 1:
                SingletonPattern.Run();
                break;
            case 2:
                SingletonThreadSafePattern.Run();
                break;
            case 3:
                SingletonLazyInitializationPattern.Run();
                break;
        }
    }

    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Wzorce projektowe.");
        Console.WriteLine();
        Console.WriteLine("Kreacyjne:");
        Console.WriteLine("  1. Singleton");
        Console.WriteLine("  2. Factory Method");
        Console.WriteLine("  3. Abstract Factory");
        Console.WriteLine("  4. Builder");

        Console.WriteLine("Strukturalne");
        Console.WriteLine("  5. Adapter");
        Console.WriteLine("  6. Bridge");
        Console.WriteLine("  7. Composite");
        Console.WriteLine("  8. Decorator");
        Console.WriteLine("  9. Facade");
        Console.WriteLine(" 10. Flyweight");

        Console.WriteLine("Behawioralne");
        Console.WriteLine(" 11. Chain of Responsibility");
        Console.WriteLine(" 12. Command");
        Console.WriteLine(" 13. Mediator");
        Console.WriteLine(" 14. State");
        Console.WriteLine(" 15. Strategy");
        Console.Write("Wybór: ");
    }
}
