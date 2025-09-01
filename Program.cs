using System;
using LesBases.ArticleType;
using LesBases.Article; 
class Program
{
    static void Main()
    {
        ArticleType article1 = new ArticleType("Pommes", 2.99m, 20, TypeArticle.Alimentaire);
        ArticleType article2 = new ArticleType("T-shirt", 19.99m, 15, TypeArticle.Habillement);
        
        Console.WriteLine("Articles initiaux:");
        article1.Afficher();
        article2.Afficher();
        
        article1.Ajouter(10);
        article2.Retirer(5);
        
        Console.WriteLine("\nArticles après modification:");
        article1.Afficher();
        article2.Afficher();
        
        Console.WriteLine($"Nom du premier article: {article1.Nom}");
        Console.WriteLine($"Prix du deuxième article: {article2.Prix:C}");
    }
}