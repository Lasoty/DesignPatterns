namespace Nadala.DesignPatterns.BehavioralPatterns.ChainOfResponsibility;

/// <summary>
/// Kod klienta zwykle działa z jednym obsługującym.
/// W większości przypadków klient nie jest świadomy, że obsługujący
/// jest częścią łańcucha.
/// </summary>
class Client
{
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
        {
            Console.WriteLine($"Klient: Kto chce {food}?");

            var result = handler.Handle(food);

            if (result != null)
            {
                Console.Write($"   {result}");
            }
            else
            {
                Console.WriteLine($"   {food} pozostało nietknięte.");
            }
        }
    }
}