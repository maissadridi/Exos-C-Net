using System;
using System.Collections.Generic;
using LesBases;
public static class ArticleExtensions
{
    public static void AfficherTous(this IEnumerable<ArticleType> articles)
    {
        foreach (var a in articles)
            Console.WriteLine($"{a.Titre} - {a.Prix}€ - {a.Type}");
    }
}