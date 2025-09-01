using System;

namespace LesBases.Article;
public struct Article
{
    public string Nom;
    public decimal Prix;
    public int Quantite;

    //Constructeur

    public Article(string nom, decimal prix, int quantite)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
    }

    //Méthodes

    public void Afficher()
    {
        Console.WriteLine($"Nom: {Nom}, Prix: {Prix}, Quantité: {Quantite}");
    }
    public void Ajouter(int quantite)
    {
        Quantite += quantite;
        Console.WriteLine($"{quantite} articles ajoutés. Nouvelle quantité: {Quantite}");
    }
    public void Retirer(int quantite)
    {
        if (quantite <= Quantite)
        {
            Quantite -= quantite;
            Console.WriteLine($"{quantite} articles retirés. Quantité restante: {Quantite}");
        }
        else
        {
            Console.WriteLine("Quantité insuffisante pour le retrait.");
        }
    }
}
