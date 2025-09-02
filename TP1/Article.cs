using System;

namespace LesBases
{
    public class Article
    {
        public string Titre { get; }
        public decimal Prix { get; private set; }

        public Article(string titre, decimal prix)
        {
            Titre = titre;
            Prix = prix;
        }

        // Méthode pour appliquer une remise
        public void AppliquerRemise(decimal montant)
        {
            if (montant < 0)
               { Console.WriteLine("Le montant de la remise ne peut pas être négatif.");
                return;}
                
            Prix = Math.Max(0, Prix - montant);
        }

        // ToString
        public override string ToString()
        {
            return $"{GetType().Name} — {Titre} ({Prix}€)";
        }
    }
}
