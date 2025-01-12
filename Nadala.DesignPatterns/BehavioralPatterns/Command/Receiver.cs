namespace Nadala.DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Klasy odbiorców zawierają ważną logikę biznesową. Wiedzą, jak wykonywać wszelkiego rodzaju operacje związane z realizacją żądania. W rzeczywistości każda klasa może służyć jako odbiorca.
/// </summary>
class Receiver
{
    public void DoSomething(string a)
    {
        Console.WriteLine($"Receiver: Pracuję nad ({a}.)");
    }

    public void DoSomethingElse(string b)
    {
        Console.WriteLine($"Receiver: Również pracuję nad ({b}.)");
    }
}