// Wzorzec projektowy Metoda Wytwórcza
//
// Cel: Zapewnia interfejs do tworzenia obiektów w klasie bazowej,
// ale pozwala podklasom zmieniać typ tworzonych obiektów.

namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;
public class FactoryMethodPattern
{
    public static void Run()
    {
        new Client().Main();
    }
}
