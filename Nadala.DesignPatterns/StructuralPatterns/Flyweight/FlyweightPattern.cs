namespace Nadala.DesignPatterns.StructuralPatterns.Flyweight;

/// <summary>
/// Wzorzec projektowy Flyweight.
/// Celem jest zmniejszenie zużycia pamięci RAM poprzez współdzielenie wspólnych 
/// części stanu między wieloma obiektami, zamiast przechowywania wszystkich danych w każdym obiekcie.
/// </summary>
public class FlyweightPattern
{
    public static void Run()
    {
        // Kod klienta zazwyczaj tworzy zestaw wstępnie zainicjowanych obiektów Flyweight
        // na etapie inicjalizacji aplikacji.
        var factory = new FlyweightFactory(
            new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
            new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
            new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
            new Car { Company = "BMW", Model = "M5", Color = "red" },
            new Car { Company = "BMW", Model = "X6", Color = "white" }
        );
        factory.listFlyweights();

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "M5",
            Color = "red"
        });

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "X1",
            Color = "red"
        });

        factory.listFlyweights();
    }

    public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("\nKlient: Dodawanie samochodu do bazy danych.");

        var flyweight = factory.GetFlyweight(new Car
        {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });

        // Kod klienta przechowuje lub oblicza stan zewnętrzny
        // i przekazuje go do metod Flyweight.
        flyweight.Operation(car);
    }
}
