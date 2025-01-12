namespace Nadala.DesignPatterns.CreationPatterns.Singleton.ThreadSafe;

// Ta implementacja Singletona nazywa się "podwójne sprawdzenie blokady". Jest bezpieczna
// w środowisku wielowątkowym i zapewnia leniwą inicjalizację obiektu Singleton.
class Singleton
{
    private Singleton() { }

    private static Singleton? _instance;

    // Teraz mamy obiekt blokady, który będzie używany do synchronizacji wątków
    // podczas pierwszego dostępu do Singletona.
    private static readonly object _lock = new();

    public static Singleton GetInstance(string value)
    {
        // Ten warunek jest potrzebny, aby zapobiec potknięciu się wątków o
        // blokadę, gdy instancja jest już gotowa.
        if (_instance == null)
        {
            // Teraz wyobraź sobie, że program właśnie został uruchomiony. Ponieważ
            // nie ma jeszcze instancji Singletona, wiele wątków może
            // jednocześnie przejść przez poprzedni warunek i dotrzeć do tego
            // punktu prawie w tym samym czasie. Pierwszy z nich przejmie
            // blokadę i będzie kontynuował, podczas gdy reszta będzie czekać tutaj.
            lock (_lock)
            {
                // Pierwszy wątek, który przejmie blokadę, dociera do tego
                // warunku, wchodzi do środka i tworzy instancję Singletona.
                // Gdy opuści blokadę, wątek, który mógł czekać na zwolnienie blokady,
                // może wtedy wejść do tej sekcji. Ale ponieważ pole Singletona jest
                // już zainicjalizowane, wątek nie utworzy nowego
                // obiektu.
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.Value = value;
                }
            }
        }
        return _instance;
    }

    // Użyjemy tej właściwości, aby udowodnić, że nasz Singleton naprawdę działa.
    public string Value { get; set; }
}
