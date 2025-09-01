using System;
using LesBases.Article; 
namespace LesBases.ArticleType
{
    public struct ArticleType
    {
        private LesBases.Article.Article articleBase;
        
        public TypeArticle Type;
        
        public string Nom
        {
            get => articleBase.Nom;
            set => articleBase.Nom = value;
        }
        
        public decimal Prix
        {
            get => articleBase.Prix;
            set => articleBase.Prix = value;
        }
        
        public int Quantite
        {
            get => articleBase.Quantite;
            set => articleBase.Quantite = value;
        }
        
        public ArticleType(string nom, decimal prix, int quantite, TypeArticle type)
        {
            articleBase = new LesBases.Article.Article(nom, prix, quantite);
            Type = type;
        }
        
        public void Afficher()
        {
            articleBase.Afficher(); 
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine("-------------------");
        }
        
        
        public void Ajouter(int quantiteAAjouter)
        {
            
            if (quantiteAAjouter > 0)
            {
                Quantite += quantiteAAjouter;
                Console.WriteLine($"{quantiteAAjouter} unités ajoutées à {Nom}");
            }
        }
        
        public void Retirer(int quantiteARetirer)
        {
            if (quantiteARetirer > 0 && quantiteARetirer <= Quantite)
            {
                Quantite -= quantiteARetirer;
                Console.WriteLine($"{quantiteARetirer} unités retirées de {Nom}");
            }
        }
        
        public LesBases.Article.Article GetArticleBase()
        {
            return articleBase;
        }
    }
}