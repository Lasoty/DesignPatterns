namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Bazowy Komponent zapewnia podstawową funkcjonalność przechowywania
/// instancji mediatora wewnątrz obiektów komponentów.
/// </summary>
class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent(IMediator mediator = null)
    {
        this._mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        this._mediator = mediator;
    }
}