namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Konkretna implementacja obsługującego: DogHandler.
/// Obsługuje żądania związane z "MeatBall".
/// </summary>
class DogHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "MeatBall")
        {
            return $"Dog: Zjem {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}