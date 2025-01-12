namespace Nadala.DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Wzorzec projektowy Composite
/// 
/// Cel: Pozwala na komponowanie obiektów w struktury drzewiaste i pracę z
/// tymi strukturami tak, jakby były pojedynczymi obiektami.
/// </summary>
public class CompositePattern
{
    public static void Run()
    {
        Client client = new Client();

        // W ten sposób kod klienta może obsługiwać proste komponenty liści...
        Leaf leaf = new Leaf();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(leaf);

        // ...jak również złożone kompozyty.
        Composite tree = new Composite();
        Composite branch1 = new Composite();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        Composite branch2 = new Composite();
        branch2.Add(new Leaf());
        tree.Add(branch1);
        tree.Add(branch2);
        Console.WriteLine("Client: Now I've got a composite tree:");
        client.ClientCode(tree);

        Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        client.ClientCode2(tree, leaf);
    }
}