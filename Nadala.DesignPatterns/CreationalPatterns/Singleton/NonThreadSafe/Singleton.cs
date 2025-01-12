namespace Nadala.DesignPatterns.CreationPatterns.Singleton.NonThreadSafe;

public sealed class Singleton
{
    // Konstruktor Singletona powinien być zawsze prywatny, aby zapobiec
    // bezpośrednim wywołaniom konstrukcji za pomocą operatora `new`.
    private Singleton() { }

    // Instancja Singletona jest przechowywana w polu statycznym. Istnieje wiele
    // sposobów inicjalizacji tego pola, z których każdy ma różne zalety i wady.
    // W tym przykładzie pokażemy najprostszy z tych sposobów, który jednak nie
    // działa dobrze w programie wielowątkowym.
    private static Singleton? _instance;

    // To jest metoda statyczna, która kontroluje dostęp do instancji singletona.
    // Przy pierwszym uruchomieniu tworzy obiekt singletona i umieszcza go w polu
    // statycznym. Przy kolejnych uruchomieniach zwraca istniejący obiekt
    // przechowywany w polu statycznym.
    public static Singleton Instance => _instance ??= new Singleton();

    // Wreszcie, każdy singleton powinien definiować jakąś logikę biznesową,
    // która może być wykonywana na jego instancji.
    public void SomeBusinessLogic()
    {
        // ...
    }
}
