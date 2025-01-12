namespace Nadala.DesignPatterns.StructuralPatterns.Composite;

class Client
{
    /// <summary>
    /// Kod klienta działa ze wszystkimi komponentami za pośrednictwem
    /// interfejsu bazowego.
    /// </summary>
    public void ClientCode(Component leaf)
    {
        Console.WriteLine($"RESULT: {leaf.Operation()}\n");
    }

    /// <summary>
    /// Dzięki temu, że operacje zarządzania dziećmi są zadeklarowane w klasie
    /// bazowej Component, kod klienta może działać z dowolnym komponentem,
    /// prostym lub złożonym, bez zależności od ich konkretnych klas.
    /// </summary>
    public void ClientCode2(Component component1, Component component2)
    {
        if (component1.IsComposite())
        {
            component1.Add(component2);
        }

        Console.WriteLine($"RESULT: {component1.Operation()}");
    }
}