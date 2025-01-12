namespace Nadala.DesignPatterns.StructuralPatterns.Decorator;

/// <summary>
/// Interfejs bazowy Component definiuje operacje, które mogą być zmieniane przez dekoratory.
/// </summary>
public abstract class Component
{
    public abstract string Operation();
}