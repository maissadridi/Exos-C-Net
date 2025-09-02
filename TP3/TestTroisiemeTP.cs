using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using LesBases;

namespace LesBases.Test
{
    class TestTroisiemeTP
    {
        List<ArticleType> articles = new List<ArticleType> {
            new ArticleType("Pomme", 2.5m, TypeArticle.Alimentaire),
            new ArticleType("Banane", 3.5m, TypeArticle.Alimentaire),
            new ArticleType("Savon", 3.2m, TypeArticle.Droguerie),
            new ArticleType("T-shirt", 15.0m, TypeArticle.Habillement)
        };

        public void Run()
        {
            // 1. linq
            var alimentaires = articles
                .Where(a => a.Type == TypeArticle.Alimentaire)
                .OrderByDescending(a => a.Prix);

            Console.WriteLine("Articles alimentaires triés par prix décroissant :");
            foreach (var a in alimentaires)
                Console.WriteLine($"{a.Titre} - {a.Prix}€");

            decimal stockTotal = articles.Sum(a => a.Prix);
            Console.WriteLine($"\n Prix total : {stockTotal}");

            // filtrage
            var mixte = new List<object>
            {
                new ArticleType("Pomme", 2.5m, TypeArticle.Alimentaire),
                "texte",
                42,
                new ArticleType("Savon", 3.2m, TypeArticle.Droguerie)
            };

            var articlesTypés = mixte.OfType<ArticleType>();
            Console.WriteLine("\n Articles typés extraits de la collection mixte :");
            foreach (var a in articlesTypés)
                Console.WriteLine($"{a.Titre} - {a.Prix}€");

            // projection
            var vueSimplifiee = articles.Select(a => new { a.Titre, a.Prix });
            Console.WriteLine("\n Projection :");
            foreach (var a in vueSimplifiee)
                Console.WriteLine($"{a.Titre} - {a.Prix}€");

            Console.WriteLine("\nAffichage avec la méthode d'extension :");
            articles.AfficherTous();

            // lambda
            decimal totalPrix = articles.Sum(a => a.Prix);
            Console.WriteLine($"\n Somme des prix totale en utilisant lambda : {totalPrix}€");
            
            string jsonString = JsonSerializer.Serialize(articles);

            Console.WriteLine(jsonString);

            // Désérialisation depuis un fichier JSON
            string chemin = "TP3/articles.json"; // adapte le chemin si besoin
            if (File.Exists(chemin))
            {
                string json = File.ReadAllText(chemin);
                var articlesJson = JsonSerializer.Deserialize<List<ArticleType>>(json);
                Console.WriteLine("\nArticles chargés depuis le fichier JSON :");
                foreach (var a in articlesJson)
                    Console.WriteLine($"{a.Titre} - {a.Prix}€ - {a.Type}");
            }
            else
            {
                Console.WriteLine($"\nFichier {chemin} introuvable.");
            }
        }
    }
}