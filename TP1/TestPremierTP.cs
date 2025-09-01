using System;
using LesBases.ArticleType;

namespace LesBases.Test
{
    class TestPremierTP
    {
       public static void TestDuPremierTP()
        {
            LesBases.ArticleType.ArticleType[] articles = new LesBases.ArticleType.ArticleType[3];
            articles[0] = new LesBases.ArticleType.ArticleType("Pommes", 2.99m, 20, TypeArticle.Alimentaire);
            articles[1] = new LesBases.ArticleType.ArticleType("T-shirt", 19.99m, 15, TypeArticle.Habillement);
            articles[2] = new LesBases.ArticleType.ArticleType("Casque", 49.99m, 5, TypeArticle.Electronique);

            Console.WriteLine("Articles initiaux :");
            foreach (var article in articles)
            {
                article.Afficher();
            }

            articles[0].Ajouter(10);    
            articles[1].Retirer(3);     
            articles[2].Ajouter(2);     

            Console.WriteLine("\nArticles après modification :");
            foreach (var article in articles)
            {
                article.Afficher();
            }
        }
    }
}