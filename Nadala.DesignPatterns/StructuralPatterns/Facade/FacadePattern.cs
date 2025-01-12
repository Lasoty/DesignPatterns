namespace Nadala.DesignPatterns.StructuralPatterns.Facade;

/// <summary>
/// Wzorzec projektowy Fasada
///
/// Cel: Zapewnia uproszczony interfejs do biblioteki, frameworka lub dowolnego innego złożonego zestawu klas.
/// </summary>
public class FacadePattern
{
    public static void Run()
    {
        // Kod klienta może mieć już utworzone niektóre obiekty podsystemu.
        // W takim przypadku warto zainicjować Fasada tymi obiektami zamiast pozwalać Fasada tworzyć nowe instancje.
        Subsystem1 subsystem1 = new();
        Subsystem2 subsystem2 = new();
        Facade facade = new(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }
}
