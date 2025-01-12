namespace Nadala.DesignPatterns.CreationPatterns.Singleton.LazyInitialization;
internal class SingletonLazyInitializationPattern
{
    public static void Run()
    {
        Singleton singleton = Singleton.Instance;
        singleton.PrintMessage();
    }
}