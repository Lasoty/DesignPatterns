namespace Nadala.DesignPatterns.StructuralPatterns.Adapter;

/// <summary>
/// Adaptee zawiera pewne użyteczne zachowanie, ale jego interfejs jest
/// niekompatybilny z istniejącym kodem klienta. Adaptee wymaga pewnej
/// adaptacji, zanim kod klienta będzie mógł go używać.
/// </summary>
class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specyficzne żądanie.";
    }
}