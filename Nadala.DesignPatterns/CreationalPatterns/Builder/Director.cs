namespace Nadala.DesignPatterns.CreationPatterns.Builder;

/// <summary>
/// Dyrektor jest odpowiedzialny jedynie za wykonywanie kroków budowy w
/// określonej kolejności. Jest to pomocne przy produkcji produktów zgodnie
/// z określonym porządkiem lub konfiguracją. Ściśle mówiąc, klasa Dyrektora
/// jest opcjonalna, ponieważ klient może bezpośrednio kontrolować budowniczych.
/// </summary>
public class Director
{
    private IBuilder _builder;

    public IBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildMinimalViableProduct()
    {
        this._builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildPartA();
        this._builder.BuildPartB();
        this._builder.BuildPartC();
    }
}