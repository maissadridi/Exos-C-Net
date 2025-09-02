using LesBases;

public delegate decimal DiscountStrategy(Article article);

public static class DiscountStrategies
{
    public static decimal PourcentageFixe(Article article, decimal pourcentage)
    {
        return article.Prix * (pourcentage / 100m);
    }

    public static decimal Remise10Pourcent(Article article)
    {
        return PourcentageFixe(article, 10m);
    }

    public static decimal RemiseParType(Article article)
    {
        if (article is ArticleType at)
        {
            switch (at.Type)
            {
                case TypeArticle.Alimentaire: return at.Prix * 0.05m;
                case TypeArticle.Habillement: return at.Prix * 0.10m;
                case TypeArticle.Loisir:      return at.Prix * 0.08m;
                case TypeArticle.Droguerie:   return at.Prix * 0.03m;
            }
        }
        return 0m;
    }
}