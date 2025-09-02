using System;

namespace LesBases
{
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    // ArticleType hérite de Publication pour garder la logique TP2
    public class ArticleType : Publication, IRentable
    {
        public TypeArticle Type { get; }

        public ArticleType(string titre, decimal prix, TypeArticle type)
            : base(titre, prix)
        {
            Type = type;
        }

        // Affichage (équivalent de ton ancien Afficher)
        public override void PublishDetails()
        {
            Console.WriteLine($"Article: {Titre} | Type: {Type} | Prix: {Prix}€");
        }

        // Exemple d’implémentation CalculateRent (tu peux changer la règle)
        public decimal CalculateRent()
        {
            // Location = 1€ + 5% du prix
            return 1.00m + (0.05m * Prix);
        }
    }
}
