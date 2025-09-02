namespace LesBases.Classes;
public class Article
{
    protected string designation;
    protected decimal prix;

    public Article()
    {
        designation = "";
        prix = 0.0m;
        
    }
    public string GetDesignation()
    {
        return designation;
    }
    public decimal GetPrix()
    {
        return prix;
    }
    public void SetDesignation(string designation)
    {
        this.designation = designation;
    }
    public void SetPrix(decimal prix)
    {
        this.prix = prix;
    }
    public void Acheter()
    {
        Console.WriteLine("acheté");
    }
}

public class Video : Article
{
    protected TimeSpan duree;
    public Video() 
    {
        duree = TimeSpan.Zero;
    }
    public TimeSpan GetDuree()
    {
        return duree;
    }
    public void SetDuree(TimeSpan duree)
    {
        this.duree = duree;
    }
    public void Afficher()
    {
        Console.WriteLine("affichée");
    }
}

public class Livre : Article
{
    protected string isbn;
    protected int nbPages;
    public Livre() 
    {
        isbn = "";
        nbPages = 0;
    }
    public string GetIsbn()
    {
        return isbn;
    }
    public int GetNbPages()
    {
        return nbPages;
    }
    public void SetIsbn(string isbn)
    {
        this.isbn = isbn;
    }
    public void SetNbPages(int nbPages)
    {
        this.nbPages = nbPages;
    }
}

public class Disque : Article
{
    protected string label;
    public Disque() 
    {
        label = "";
    }
    public string GetLabel()
    {
        return label;
    }
    public void SetLabel(string label)
    {
        this.label = label;
    }
    public void Ecouter()
    {
        Console.WriteLine("écouté");
    }
}

public class Proche : Livre
{
    private string categorie;
    public Proche() 
    {
        categorie = "";
    }
    public string GetCategorie()
    {
        return categorie;
    }
    public void SetCategorie(string categorie)
    {
        this.categorie = categorie;
    }
}

public class Broche : Livre
{
    public Broche() 
    {
    }


}