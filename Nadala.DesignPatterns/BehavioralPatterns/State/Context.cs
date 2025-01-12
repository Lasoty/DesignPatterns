namespace Nadala.DesignPatterns.BehavioralPatterns.State;

/// <summary>
/// Kontekst definiuje interfejs interesujący dla klientów. Utrzymuje również
/// odniesienie do instancji podklasy State, która reprezentuje bieżący stan Kontekstu.
/// </summary>
class Context
{
    // Odniesienie do bieżącego stanu Kontekstu.
    private State _state = null;

    public Context(State state)
    {
        this.TransitionTo(state);
    }

    // Kontekst pozwala na zmianę obiektu State w czasie wykonywania.
    public void TransitionTo(State state)
    {
        Console.WriteLine($"Context: Przejście do {state.GetType().Name}.");
        this._state = state;
        this._state.SetContext(this);
    }

    // Kontekst deleguje część swojego zachowania do bieżącego obiektu State.
    public void Request1()
    {
        this._state.Handle1();
    }

    public void Request2()
    {
        this._state.Handle2();
    }
}