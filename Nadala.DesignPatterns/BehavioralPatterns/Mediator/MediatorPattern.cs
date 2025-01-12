namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Wzorzec Projektowy Mediator
///
/// Cel: Pozwala zmniejszyć chaotyczne zależności między obiektami. Wzorzec
/// ogranicza bezpośrednią komunikację między obiektami i zmusza je do
/// współpracy wyłącznie za pośrednictwem obiektu mediatora.
/// </summary>
public class MediatorPattern
{
    public static void Run()
    {
        // Kod klienta.
        Component1 component1 = new();
        Component2 component2 = new();
        new ConcreteMediator(component1, component2);

        Console.WriteLine("Klient uruchamia operację A.");
        component1.DoA();

        Console.WriteLine();

        Console.WriteLine("Klient uruchamia operację D.");
        component2.DoD();
    }
}
