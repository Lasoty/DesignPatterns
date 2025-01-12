namespace Nadala.DesignPatterns.BehavioralPatterns.Strategy;

/// <summary>
/// Wzorzec Projektowy Strategia
///
/// Cel: Pozwala zdefiniować rodzinę algorytmów, umieścić każdy z nich w
/// osobnej klasie i uczynić ich obiekty wymiennymi.
/// </summary>
public class StrategyPattern
{
    public static void Run()
    {
        // Kod klienta wybiera konkretną strategię i przekazuje ją do
        // kontekstu. Klient powinien być świadomy różnic między
        // strategiami, aby dokonać właściwego wyboru.
        var context = new Context();

        Console.WriteLine("Klient: Strategia ustawiona na normalne sortowanie.");
        context.SetStrategy(new ConcreteStrategyA());
        context.DoSomeBusinessLogic();

        Console.WriteLine();

        Console.WriteLine("Klient: Strategia ustawiona na sortowanie odwrotne.");
        context.SetStrategy(new ConcreteStrategyB());
        context.DoSomeBusinessLogic();
    }
}
