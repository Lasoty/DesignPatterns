namespace Nadala.DesignPatterns.CreationPatterns.Singleton.NonThreadSafe;

// Wzorzec projektowy Singleton
//
// Cel: Umożliwia zapewnienie, że klasa ma tylko jedną instancję, zapewniając
// globalny punkt dostępu do tej instancji.

// Klasa Singleton definiuje metodę `GetInstance`, która służy jako alternatywa
// dla konstruktora i pozwala klientom na dostęp do tej samej instancji tej klasy
// wielokrotnie.

// PL: Singleton powinien zawsze być klasą 'sealed', aby zapobiec dziedziczeniu
// klasy przez zewnętrzne klasy, a także przez klasy zagnieżdżone.

public class SingletonPattern
{
    public static void Run()
    {
        // Kod klienta.
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        Console.WriteLine(s1 == s2
            ? "Singleton działa, obie zmienne zawierają tę samą instancję."
            : "Singleton nie działa, zmienne zawierają różne instancje.");
    }
}
