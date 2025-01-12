namespace Nadala.DesignPatterns.StructuralPatterns.Adapter;

/// <summary>
/// Adapter sprawia, że interfejs Adaptee jest kompatybilny z interfejsem Target.
/// </summary>
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"To jest '{this._adaptee.GetSpecificRequest()}'";
    }
}