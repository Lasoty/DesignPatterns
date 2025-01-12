namespace Nadala.DesignPatterns.StructuralPatterns.Adapter;

/// <summary>
/// Wzorzec projektowy Adapter
/// </summary>
/// <remarks>
/// Zapewnia jednolity interfejs, który pozwala obiektom o niekompatybilnych
/// interfejsach współpracować.
/// </remarks>
public class AdapterPattern
{
    public static void Run()
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        Console.WriteLine("Interfejs Adaptee jest niekompatybilny z klientem.");
        Console.WriteLine("Ale dzięki adapterowi klient może wywołać jego metodę.");

        Console.WriteLine(target.GetRequest());
    }
}
