namespace Nadala.DesignPatterns.StructuralPatterns.Facade;

/// <summary>
/// Klasa Fasada zapewnia prosty interfejs do złożonej logiki jednego lub kilku podsystemów.
/// Fasada deleguje żądania klienta do odpowiednich obiektów w podsystemie.
/// Fasada jest również odpowiedzialna za zarządzanie ich cyklem życia.
/// Wszystko to chroni klienta przed niepożądaną złożonością podsystemu.
/// </summary>
public class Facade
{
    protected Subsystem1 _subsystem1;

    protected Subsystem2 _subsystem2;

    public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        this._subsystem1 = subsystem1;
        this._subsystem2 = subsystem2;
    }

    // Metody Fasady są wygodnymi skrótami do zaawansowanej funkcjonalności podsystemów.
    // Jednak klienci mają dostęp tylko do części możliwości podsystemu.
    public string Operation()
    {
        string result = "Fasada inicjuje podsystemy:\n";
        result += this._subsystem1.operation1();
        result += this._subsystem2.operation1();
        result += "Fasada zleca podsystemom wykonanie akcji:\n";
        result += this._subsystem1.operationN();
        result += this._subsystem2.operationZ();
        return result;
    }
}