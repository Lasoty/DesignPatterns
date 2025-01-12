namespace Nadala.DesignPatterns.BehavioralPatterns.Strategy;

/// <summary>
/// Kontekst definiuje interfejs interesujący dla klientów.
/// </summary>
class Context
{
    /// <summary>
    /// Kontekst utrzymuje referencję do jednego z obiektów Strategii.
    /// Kontekst nie zna konkretnej klasy strategii. Powinien
    /// współpracować ze wszystkimi strategiami za pośrednictwem interfejsu Strategii.
    /// </summary>
    private IStrategy _strategy;

    public Context()
    { }

    /// <summary>
    /// Zazwyczaj Kontekst akceptuje strategię przez konstruktor, ale
    /// także zapewnia setter do zmiany jej w czasie działania.
    /// </summary>
    public Context(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    /// <summary>
    /// Zazwyczaj Kontekst pozwala na zastąpienie obiektu Strategii w czasie działania.
    /// </summary>
    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    /// <summary>
    /// Kontekst deleguje część pracy do obiektu Strategii zamiast
    /// implementować wiele wersji algorytmu samodzielnie.
    /// </summary>
    public void DoSomeBusinessLogic()
    {
        Console.WriteLine("Kontekst: Sortowanie danych za pomocą strategii (nie wiem jak to zrobi)");
        var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

        string resultStr = string.Empty;
        foreach (var element in result as List<string>)
        {
            resultStr += element + ",";
        }

        Console.WriteLine(resultStr);
    }
}