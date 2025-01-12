namespace Nadala.DesignPatterns.BehavioralPatterns.Command;

/// <summary>
/// Niektóre polecenia mogą samodzielnie wykonywać proste operacje.
/// </summary>
class SimpleCommand : ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
        this._payload = payload;
    }

    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: Zobacz, mogę robić proste rzeczy, takie jak drukowanie ({this._payload})");
    }
}