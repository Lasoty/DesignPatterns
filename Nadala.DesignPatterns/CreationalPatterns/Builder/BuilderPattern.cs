namespace Nadala.DesignPatterns.CreationPatterns.Builder;

public class BuilderPattern
{
    public static void Run()
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        Console.WriteLine("Standardowy podstawowy produkt:");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Standardowy pełny produkt:");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Niestandardowy produkt:");
        builder.BuildPartA();
        builder.BuildPartC();
        Console.Write(builder.GetProduct().ListParts());
    }
}
