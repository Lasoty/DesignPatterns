namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

public class Client
{
    /// <summary>
    /// Kod klienta działa ze wszystkimi obiektami za pomocą interfejsu Component.
    /// W ten sposób może pozostać niezależny od konkretnych klas komponentów, z którymi pracuje.
    /// </summary>
    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}