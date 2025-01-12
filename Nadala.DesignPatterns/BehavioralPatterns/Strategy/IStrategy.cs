namespace Nadala.DesignPatterns.BehavioralPatterns.Strategy;

/// <summary>
/// Interfejs Strategii deklaruje operacje wspólne dla wszystkich obsługiwanych
/// wersji niektórych algorytmów.
/// </summary>
public interface IStrategy
{
    object DoAlgorithm(object data);
}