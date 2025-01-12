namespace Nadala.DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Wzorzec projektowy Command
///
/// Cel: Przekształca żądanie w samodzielny obiekt, który zawiera wszystkie informacje o żądaniu. Ta transformacja pozwala parametryzować metody różnymi żądaniami, opóźniać lub kolejkować wykonanie żądania oraz wspierać operacje odwracalne.
/// </summary>
public class CommandPattern
{
    public static void Run()
    {
        // Kod klienta może parametryzować obiekt wywołujący dowolnymi poleceniami.
        Invoker invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Powiedz cześć!"));
        Receiver receiver = new Receiver();
        invoker.SetOnFinish(new ComplexCommand(receiver, "Wyślij email", "Zapisz raport"));

        invoker.DoSomethingImportant();
    }
}
