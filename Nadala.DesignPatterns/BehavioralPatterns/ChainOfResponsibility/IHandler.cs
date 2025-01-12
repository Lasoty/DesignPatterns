namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Interfejs IHandler deklaruje metodę do budowania łańcucha obsługujących
/// oraz metodę do przetwarzania żądania.
/// </summary>
public interface IHandler
{
    /// <summary>
    /// Ustawia kolejny element w łańcuchu obsługujących.
    /// </summary>
    IHandler SetNext(IHandler handler);

    /// <summary>
    /// Przetwarza żądanie lub przekazuje je dalej.
    /// </summary>
    object Handle(object request);
}