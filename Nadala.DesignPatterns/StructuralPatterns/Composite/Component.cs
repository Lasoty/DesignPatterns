namespace Nadala.DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Klasa bazowa Component deklaruje wspólne operacje zarówno dla prostych,
/// jak i złożonych obiektów kompozycji.
/// </summary>
abstract class Component
{
    public Component() { }

    /// <summary>
    /// Klasa bazowa Component może implementować pewne domyślne zachowanie
    /// lub pozostawić je klasom pochodnym (poprzez zadeklarowanie metody
    /// zawierającej zachowanie jako "abstrakcyjnej").
    /// </summary>
    public abstract string Operation();

    /// <summary>
    /// W niektórych przypadkach korzystne byłoby zdefiniowanie operacji
    /// zarządzania dziećmi bezpośrednio w klasie bazowej Component. W ten
    /// sposób nie trzeba ujawniać żadnych konkretnych klas komponentów
    /// kodowi klienta, nawet podczas montażu drzewa obiektów. Wadą jest to,
    /// że te metody będą puste dla komponentów na poziomie liści.
    /// </summary>
    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Można dostarczyć metodę, która pozwala kodowi klienta ustalić, czy
    /// komponent może mieć dzieci.
    /// </summary>
    public virtual bool IsComposite()
    {
        return true;
    }
}