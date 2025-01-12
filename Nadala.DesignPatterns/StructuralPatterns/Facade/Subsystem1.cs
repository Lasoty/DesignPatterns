namespace Nadala.DesignPatterns.StructuralPatterns.Facade;

/// <summary>
/// Podsystem może przyjmować żądania zarówno od fasady, jak i bezpośrednio od klienta.
/// W każdym przypadku, dla Podsystemu, Fasada jest kolejnym klientem i nie jest częścią Podsystemu.
/// </summary>
public class Subsystem1
{
    public string operation1()
    {
        return "Podsystem1: Gotowy!\n";
    }

    public string operationN()
    {
        return "Podsystem1: Start!\n";
    }
}