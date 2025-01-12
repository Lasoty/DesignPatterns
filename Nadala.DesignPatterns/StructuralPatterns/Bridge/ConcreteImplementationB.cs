namespace Nadala.DesignPatterns.StructuralPatterns.Bridge;

class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationB: Wynik na platformie B.\n";
    }
}