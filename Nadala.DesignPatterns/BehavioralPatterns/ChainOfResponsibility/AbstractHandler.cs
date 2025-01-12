namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Domyślne zachowanie łańcuchowe można zaimplementować w abstrakcyjnej 
/// klasie bazowej.
/// </summary>
abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    /// <summary>
    /// Ustawia kolejny element w łańcuchu i umożliwia wygodne łączenie 
    /// obsługujących w jeden ciąg, np.: monkey.SetNext(squirrel).SetNext(dog).
    /// </summary>
    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    /// <summary>
    /// Przetwarza żądanie lub przekazuje je do kolejnego elementu w łańcuchu.
    /// </summary>
    public virtual object Handle(object request)
    {
        if (this._nextHandler != null)
        {
            return this._nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}