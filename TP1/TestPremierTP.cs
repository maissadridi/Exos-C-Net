using System;
using LesBases;

namespace LesBases.Test
{
    class TestPremierTP
    {
        public static void TestDuPremierTP()
        {
            // Création d'un tableau d'articles typés
            ArticleType[] articles = new ArticleType[3];
            articles[0] = new ArticleType("Pommes", 2.99m, TypeArticle.Alimentaire);
            articles[1] = new ArticleType("T-shirt", 19.99m, TypeArticle.Habillement);
            articles[2] = new ArticleType("Casque", 49.99m, TypeArticle.Loisir); 

            Console.WriteLine("Articles initiaux :");
            foreach (var article in articles)
            {
                article.PublishDetails();
            }

            Console.WriteLine("\nCoûts de location :");
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Titre} => location {article.CalculateRent():0.00}€");
            }
        }
    }
}
