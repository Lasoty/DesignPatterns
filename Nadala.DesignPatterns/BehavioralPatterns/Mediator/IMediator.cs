namespace Nadala.DesignPatterns.BehavioralPatterns.Mediator;

/// <summary>
/// Interfejs Mediatora deklaruje metodę używaną przez komponenty do powiadamiania
/// mediatora o różnych zdarzeniach. Mediator może reagować na te zdarzenia i
/// przekazywać wykonanie innym komponentom.
/// </summary>
public interface IMediator
{
    void Notify(object sender, string ev);
}