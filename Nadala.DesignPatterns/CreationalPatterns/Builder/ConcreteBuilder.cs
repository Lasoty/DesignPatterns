namespace Nadala.DesignPatterns.CreationPatterns.Builder;

/// <summary>
/// Klasy Konkretnych Budowniczych podążają za interfejsem Budowniczego i
/// dostarczają specyficzne implementacje kroków budowy. Twój program może
/// mieć kilka wariantów Budowniczych, zaimplementowanych w różny sposób.
/// </summary>
public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    /// <summary>
    /// Nowa instancja budowniczego powinna zawierać pusty obiekt produktu,
    /// który jest używany w dalszym montażu.
    /// </summary>
    public ConcreteBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._product = new Product();
    }

    public void BuildPartA()
    {
        this._product.Add("PartA1");
    }

    public void BuildPartB()
    {
        this._product.Add("PartB1");
    }

    public void BuildPartC()
    {
        this._product.Add("PartC1");
    }

    /// <summary>
    /// Konkretny Budowniczy powinien dostarczać własne metody do
    /// pobierania wyników. Jest tak, ponieważ różne typy budowniczych mogą
    /// tworzyć zupełnie różne produkty, które nie podążają za tym samym
    /// interfejsem. Dlatego takie metody nie mogą być zadeklarowane w
    /// podstawowym interfejsie Budowniczego (przynajmniej w statycznie
    /// typowanym języku programowania).
    ///
    /// Zazwyczaj, po zwróceniu końcowego wyniku do klienta, instancja
    /// budowniczego powinna być gotowa do rozpoczęcia produkcji innego
    /// produktu. Dlatego zwykle wywołuje się metodę reset na końcu ciała
    /// metody `GetProduct`. Jednak to zachowanie nie jest obowiązkowe i
    /// można sprawić, że budowniczy będzie czekał na wyraźne wywołanie
    /// reset przez kod klienta przed usunięciem poprzedniego wyniku.
    /// </summary>
    public Product GetProduct()
    {
        Product result = this._product;

        this.Reset();

        return result;
    }
}