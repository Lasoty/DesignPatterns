namespace Nadala.DesignPatterns.CreationPatterns.Singleton.ThreadSafe;

public class SingletonThreadSafePattern
{
    public static void Run()
    {
        // Kod klienta.

        Console.WriteLine(
            "{0}\n{1}\n\n{2}\n",
            "Jeśli widzisz tę samą wartość, to singleton został ponownie użyty (hurra!)",
            "Jeśli widzisz różne wartości, to zostały utworzone 2 singletony (buuu!!)",
            "WYNIK:"
        );

        Thread process1 = new Thread(() =>
        {
            TestSingleton("FOO");
        });
        Thread process2 = new Thread(() =>
        {
            TestSingleton("BAR");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();
    }

    public static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
}
