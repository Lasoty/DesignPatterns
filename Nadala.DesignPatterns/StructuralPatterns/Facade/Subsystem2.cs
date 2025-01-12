namespace Nadala.DesignPatterns.StructuralPatterns.Facade;

/// <summary>
/// Niektóre fasady mogą współpracować z wieloma podsystemami jednocześnie.
/// </summary>
public class Subsystem2
{
    public string operation1()
    {
        return "Podsystem2: Przygotuj się!\n";
    }

    public string operationZ()
    {
        return "Podsystem2: Ognia!\n";
    }
}