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

    public class ArticleType : Publication, IRentable
    {
        public TypeArticle Type { get; }

        public ArticleType(string titre, decimal prix, TypeArticle type)
            : base(titre, prix)
        {
            Type = type;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Article: {Titre} | Type: {Type} | Prix: {Prix}€");
        }

        public decimal CalculateRent()
        {
            return 1.00m + (0.05m * Prix);
        }
    }
}
