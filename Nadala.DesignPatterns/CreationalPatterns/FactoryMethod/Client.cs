namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;

class Client
{
    public void Main()
    {
        Console.WriteLine("Aplikacja: Uruchomiona z ConcreteCreator1.");
        ClientCode(new ConcreteCreator1());

        Console.WriteLine("");

        Console.WriteLine("Aplikacja: Uruchomiona z ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());
    }

    // Kod klienta działa z instancją konkretnego twórcy, choć
    // przez jego bazowy interfejs. Dopóki klient pracuje z
    // twórcą za pośrednictwem interfejsu bazowego, można mu przekazać dowolną podklasę twórcy.
    public void ClientCode(Creator creator)
    {
        // ...
        Console.WriteLine("Klient: Nie jestem świadomy klasy twórcy," +
                          "ale to nadal działa.\n" + creator.SomeOperation());
        // ...
    }
}