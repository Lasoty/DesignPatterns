namespace Nadala.DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Jednak niektóre polecenia mogą delegować bardziej złożone operacje do innych obiektów, zwanych "odbiorcami".
/// </summary>
class ComplexCommand : ICommand
{
    private Receiver _receiver;

    // Dane kontekstowe, wymagane do uruchomienia metod odbiorcy.
    private string _a;

    private string _b;

    /// <summary>
    /// Złożone polecenia mogą akceptować jeden lub kilka obiektów odbiorcy wraz z danymi kontekstowymi za pośrednictwem konstruktora.
    /// </summary>
    public ComplexCommand(Receiver receiver, string a, string b)
    {
        this._receiver = receiver;
        this._a = a;
        this._b = b;
    }

    /// <summary>
    /// Polecenia mogą delegować dowolne metody odbiorcy.
    /// </summary>
    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Złożone rzeczy powinny być wykonywane przez obiekt odbiorcy.");
        this._receiver.DoSomething(this._a);
        this._receiver.DoSomethingElse(this._b);
    }
}