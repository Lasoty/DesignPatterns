namespace Nadala.DesignPatterns.CreationPatterns.Singleton.LazyInitialization;

public sealed class Singleton
{
    private Singleton()
    {
    }
    private static readonly Lazy<Singleton> lazy = new(() => new Singleton());
    public static Singleton Instance => lazy.Value;

    public void PrintMessage()
    {
        Console.WriteLine("Wiadomość z instancji singletona.");
    }
}