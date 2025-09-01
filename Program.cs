using System;
using LesBases.ArticleType;

class Program
{
    static void Main()
    {
        ArticleType[] articles = new ArticleType[3];
        articles[0] = new ArticleType("Pommes", 2.99m, 20, TypeArticle.Alimentaire);
        articles[1] = new ArticleType("T-shirt", 19.99m, 15, TypeArticle.Habillement);
        articles[2] = new ArticleType("Casque", 49.99m, 5, TypeArticle.Electronique);

        Console.WriteLine("Articles initiaux :");
        foreach (var article in articles)
        {
            article.Afficher();
        }

        // Manipulation : ajout et retrait
        articles[0].Ajouter(10);    // Ajoute 10 pommes
        articles[1].Retirer(3);     // Retire 3 t-shirts
        articles[2].Ajouter(2);     // Ajoute 2 casques

        Console.WriteLine("\nArticles après modification :");
        foreach (var article in articles)
        {
            article.Afficher();
        }
    }
}