namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Konkretna implementacja obsługującego: SquirrelHandler.
/// Obsługuje żądania związane z "Nut".
/// </summary>
class SquirrelHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "Nut")
        {
            return $"Squirrel: Zjem {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}