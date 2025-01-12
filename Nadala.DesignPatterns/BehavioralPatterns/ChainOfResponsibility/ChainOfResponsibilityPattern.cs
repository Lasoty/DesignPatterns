namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Wzorzec projektowy Chain of Responsibility.
/// Celem jest umożliwienie przekazywania żądań wzdłuż łańcucha obsługujących.
/// Po otrzymaniu żądania każdy obsługujący decyduje, czy je przetworzyć, czy 
/// przekazać dalej.
/// </summary>
public class ChainOfResponsibilityPattern
{
    public static void Run()
    {
        // Druga część kodu klienta konstruuje faktyczny łańcuch.
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();

        monkey.SetNext(squirrel).SetNext(dog);

        // Klient powinien być w stanie wysłać żądanie do dowolnego obsługującego,
        // nie tylko do pierwszego w łańcuchu.
        Console.WriteLine("Łańcuch: Monkey > Squirrel > Dog\n");
        Client.ClientCode(monkey);
        Console.WriteLine();

        Console.WriteLine("Podłańcuch: Squirrel > Dog\n");
        Client.ClientCode(squirrel);
    }
}
