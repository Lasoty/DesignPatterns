namespace Nadala.DesignPatterns.BehavioralPatterns.Strategy;

/// <summary>
/// Konkretne Strategie implementują algorytm, przestrzegając
/// interfejsu Strategii. Interfejs sprawia, że są one wymienne w Kontekście.
/// </summary>
class ConcreteStrategyA : IStrategy
{
    public object DoAlgorithm(object data)
    {
        var list = data as List<string>;
        list.Sort();

        return list;
    }
}