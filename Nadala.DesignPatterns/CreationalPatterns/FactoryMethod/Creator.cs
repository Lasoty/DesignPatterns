namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;

/// <summary>
/// Klasa Creator deklaruje metodę fabrykującą, która ma zwracać
/// obiekt klasy Product. Podklasy Creator zazwyczaj dostarczają implementację tej metody.
/// </summary>
abstract class Creator
{
    // Należy zauważyć, że Creator może również dostarczyć domyślną implementację
    // metody fabrykującej.
    public abstract IProduct FactoryMethod();

    // Należy również zauważyć, że pomimo swojej nazwy, główną
    // odpowiedzialnością Creator nie jest tworzenie produktów. Zazwyczaj zawiera on pewną
    // logikę biznesową, która opiera się na obiektach Product, zwracanych przez
    // metodę fabrykującą. Podklasy mogą pośrednio zmieniać tę logikę biznesową
    // poprzez nadpisanie metody fabrykującej i zwracanie innego typu
    // produktu z niej.
    public string SomeOperation()
    {
        // Wywołaj metodę fabrykującą, aby utworzyć obiekt Product.
        var product = FactoryMethod();
        // Teraz użyj produktu.
        var result = "Creator: Ten sam kod kreatora właśnie współpracował z "
                     + product.Operation();

        return result;
    }
}
