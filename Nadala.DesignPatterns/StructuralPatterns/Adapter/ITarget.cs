namespace Nadala.DesignPatterns.StructuralPatterns.Adapter;

/// <summary>
/// Target definiuje interfejs specyficzny dla domeny używany przez kod klienta.
/// </summary>
public interface ITarget
{
    string GetRequest();
}