using System;

namespace LesBases
{
    public enum CategorieLivre { Poche, Broche }

    public class Livre : Publication, IRentable
    {
        public string Auteur { get; }
        public CategorieLivre Categorie { get; }

        public Livre(string titre, string auteur, CategorieLivre categorie, decimal prix)
            : base(titre, prix)
        {
            Auteur = auteur;
            Categorie = categorie;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre: '{Titre}' par {Auteur} — Catégorie: {Categorie} — Prix: {Prix}€");
        }

        public decimal CalculateRent()
        {
            decimal rent = 1.50m + (0.05m * Prix);
            if (Categorie == CategorieLivre.Broche) rent += 0.50m;
            return rent;
        }
    }
}
