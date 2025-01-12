namespace Nadala.DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Obiekt wywołujący jest powiązany z jednym lub kilkoma poleceniami. Wysyła żądanie do polecenia.
/// </summary>
class Invoker
{
    private ICommand _onStart;

    private ICommand _onFinish;

    // Inicjalizacja poleceń.
    public void SetOnStart(ICommand command)
    {
        this._onStart = command;
    }

    public void SetOnFinish(ICommand command)
    {
        this._onFinish = command;
    }

    /// <summary>
    /// Obiekt wywołujący nie zależy od konkretnych klas poleceń ani odbiorców. Przekazuje żądanie do odbiorcy pośrednio, wykonując polecenie.
    /// </summary>
    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Czy ktoś chce coś zrobić, zanim zacznę?");
        if (this._onStart is ICommand)
        {
            this._onStart.Execute();
        }

        Console.WriteLine("Invoker: ...robię coś naprawdę ważnego...");

        Console.WriteLine("Invoker: Czy ktoś chce coś zrobić po zakończeniu?");
        if (this._onFinish is ICommand)
        {
            this._onFinish.Execute();
        }
    }
}