using System.Text.Json;

namespace Nadala.DesignPatterns.StructuralPatterns.Flyweight;

/// <summary>
/// Flyweight przechowuje wspólną część stanu (tzw. stan wewnętrzny), który 
/// należy do wielu rzeczywistych obiektów biznesowych. Flyweight akceptuje 
/// resztę stanu (stan zewnętrzny, unikalny dla każdego obiektu) poprzez 
/// parametry metod.
/// </summary>
public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }

    public void Operation(Car uniqueState)
    {
        string s = JsonSerializer.Serialize(this._sharedState);
        string u = JsonSerializer.Serialize(uniqueState);
        Console.WriteLine($"Flyweight: Wyświetlanie współdzielonego {s} i unikalnego {u} stanu.");
    }
}