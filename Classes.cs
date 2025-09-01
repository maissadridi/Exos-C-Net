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

public class Video
{
    protected TimeSpan duree;
    
    public void Afficher()
    {
        Console.WriteLine("affichée");
    }
}

public class Livre
{
    protected string isbn;
    protected int nbPages;
}

public class Disque
{
    protected string label;
    
    public void Ecouter()
    {
        Console.WriteLine("écouté");
    }
}

public class Proche
{
    private string categorie;
}

public class Broche
{
}