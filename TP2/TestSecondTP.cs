using System;
using System.Collections.Generic;
using LesBases;

namespace LesBases.Test
{
    class TestSecondTP
    {
        public static void Run()
        {
            var articles = new List<Article>
            {
                new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", CategorieLivre.Poche, 6.90m),
                new Livre("Clean Code", "Robert C. Martin", CategorieLivre.Broche, 32.00m),
                new Disque("Kind of Blue", 46, 14.99m),
                new Video("Inception", "Blu-ray", 19.99m),
                new ArticleType("Pommes", 2.99m, TypeArticle.Alimentaire)
            };

            Console.WriteLine("=== Test IRentable (CalculateRent) ===");
            foreach (var a in articles)
            {
                if (a is IRentable r)
                {
                    Console.WriteLine($"{a} => location = {r.CalculateRent():0.00}€");
                }
            }

            // --- Classe abstraite : Publication.PublishDetails() ---
            Console.WriteLine("\n=== Test Publication (PublishDetails) ===");
            foreach (var a in articles)
            {
                if (a is Publication p)
                {
                    p.PublishDetails();
                }
            }

        
        }

      
    }
}
