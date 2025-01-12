namespace Nadala.DesignPatterns.StructuralPatterns.Flyweight;

/// <summary>
/// FlyweightFactory tworzy i zarządza obiektami Flyweight. 
/// Zapewnia poprawne współdzielenie obiektów Flyweight. 
/// Gdy klient żąda Flyweight, fabryka zwraca istniejącą instancję lub tworzy 
/// nową, jeśli nie istnieje.
/// </summary>
public class FlyweightFactory
{
    private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

    public FlyweightFactory(params Car[] args)
    {
        foreach (var elem in args)
        {
            flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
        }
    }

    /// <summary>
    /// Zwraca klucz w postaci stringa dla podanego stanu Flyweight.
    /// </summary>
    public string getKey(Car key)
    {
        List<string> elements = new List<string>();

        elements.Add(key.Model);
        elements.Add(key.Color);
        elements.Add(key.Company);

        if (key.Owner != null && key.Number != null)
        {
            elements.Add(key.Number);
            elements.Add(key.Owner);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    /// <summary>
    /// Zwraca istniejący Flyweight z danym stanem lub tworzy nowy.
    /// </summary>
    public Flyweight GetFlyweight(Car sharedState)
    {
        string key = this.getKey(sharedState);

        if (flyweights.Where(t => t.Item2 == key).Count() == 0)
        {
            Console.WriteLine("FlyweightFactory: Nie można znaleźć Flyweight, tworzenie nowego.");
            this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Ponowne użycie istniejącego Flyweight.");
        }
        return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
    }

    public void listFlyweights()
    {
        var count = flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: Mam {count} obiektów Flyweight:");
        foreach (var flyweight in flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}