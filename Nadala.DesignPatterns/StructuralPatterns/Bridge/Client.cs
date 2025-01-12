namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

class Client
{
    /// <summary>
    /// Poza fazą inicjalizacji, gdzie obiekt Abstrakcji jest powiązany z konkretnym
    /// obiektem Implementacji, kod klienta powinien zależeć tylko od klasy Abstrakcji.
    /// W ten sposób kod klienta może obsługiwać dowolną kombinację abstrakcji i implementacji.
    /// </summary>
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}