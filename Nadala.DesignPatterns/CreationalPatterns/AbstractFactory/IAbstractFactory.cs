namespace Nadala.DesignPatterns.CreationalPatterns.AbstractFactory;

/// <summary>
/// Interfejs Abstract Factory deklaruje zestaw metod, które zwracają
/// różne abstrakcyjne produkty. Te produkty nazywane są rodziną i są
/// powiązane przez wysoki poziom tematyczny lub koncepcyjny. Produkty jednej rodziny
/// zazwyczaj mogą współpracować ze sobą. Rodzina produktów może
/// mieć kilka wariantów, ale produkty jednego wariantu są niekompatybilne
/// z produktami innego wariantu.
/// </summary>
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}