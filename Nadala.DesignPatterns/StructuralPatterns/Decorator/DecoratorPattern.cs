namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Wzorzec projektowy Dekorator
/// 
/// Cel: Pozwala na dołączanie nowych zachowań do obiektów poprzez umieszczanie tych obiektów wewnątrz specjalnych obiektów opakowujących,
/// które zawierają te zachowania.
/// </summary>
public class DecoratorPattern
{
    public static void Run()
    {
        Client client = new();

        var simple = new ConcreteComponent();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(simple);
        Console.WriteLine();

        // ...jak również dekorowane.
        //
        // Zauważ, jak dekoratory mogą opakowywać nie tylko proste komponenty, ale także inne dekoratory.
        ConcreteDecoratorA decorator1 = new(simple);
        ConcreteDecoratorB decorator2 = new(decorator1);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.ClientCode(decorator2);
    }
}
