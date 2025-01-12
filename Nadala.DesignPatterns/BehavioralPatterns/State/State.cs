namespace Nadala.DesignPatterns.BehavioralPatterns.State;

/// <summary>
/// Klasa bazowa State deklaruje metody, które powinny implementować wszystkie konkretne stany
/// oraz zapewnia odniesienie do obiektu Context, z którym jest powiązana.
/// To odniesienie może być używane przez stany do przejścia Kontekstu do innego stanu.
/// </summary>
abstract class State
{
    protected Context _context;

    public void SetContext(Context context)
    {
        this._context = context;
    }

    public abstract void Handle1();

    public abstract void Handle2();
}