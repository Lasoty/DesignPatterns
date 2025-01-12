namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Konkretna implementacja obsługującego: MonkeyHandler.
/// Obsługuje żądania związane z "Banana".
/// </summary>
class MonkeyHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Banana")
        {
            return $"Monkey: Zjem {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}