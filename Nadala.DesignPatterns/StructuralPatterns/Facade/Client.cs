namespace Nadala.DesignPatterns.StructuralPatterns.Facade;

/// <summary>
/// Kod klienta działa z złożonymi podsystemami za pośrednictwem prostego interfejsu zapewnianego przez Fasada.
/// Gdy fasada zarządza cyklem życia podsystemu, klient może nawet nie wiedzieć o istnieniu podsystemu.
/// Takie podejście pozwala utrzymać złożoność pod kontrolą.
/// </summary>
class Client
{
    public static void ClientCode(Facade facade)
    {
        Console.Write(facade.Operation());
    }
}