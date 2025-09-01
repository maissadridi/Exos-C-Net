namespace Commerce;
public class Article
{
    protected string designation;
    protected decimal prix;

    public void Acheter()
    {
        Console.WriteLine("acheté");
    }
}

public class Video : Article
{
    protected TimeSpan duree;
    
    public void Afficher()
    {
        Console.WriteLine("affichée");
    }
}

public class Livre : Article
{
    protected string isbn;
    protected int nbPages;
}

public class Disque : Article
{
    protected string label;
    
    public void Ecouter()
    {
        Console.WriteLine("écouté");
    }
}

public class Proche : Livre
{
    private string categorie;
}

public class Broche : Livre
{
}