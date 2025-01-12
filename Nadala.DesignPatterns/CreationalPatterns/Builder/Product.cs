namespace Nadala.DesignPatterns.CreationPatterns.Builder;

/// <summary>
/// Wzorzec Budowniczy ma sens tylko wtedy, gdy twoje produkty są
/// dość złożone i wymagają rozbudowanej konfiguracji.
///
/// W przeciwieństwie do innych wzorców kreacyjnych, różni konkretni
/// budowniczowie mogą produkować niepowiązane produkty. Innymi słowy,
/// wyniki różnych budowniczych mogą nie zawsze podążać za tym samym
/// interfejsem.
/// </summary>
public class Product
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        this._parts.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < this._parts.Count; i++)
        {
            str += this._parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2); // usuwanie ostatniego ", "

        return "Części produktu: " + str + "\n";
    }
}