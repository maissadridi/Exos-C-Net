using System;

namespace LesBases
{
    public class Disque : Publication, IRentable
    {
        public int DureeMinutes { get; }

        public Disque(string titre, int dureeMinutes, decimal prix)
            : base(titre, prix)
        {
            DureeMinutes = dureeMinutes;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Disque: '{Titre}' — Durée: {DureeMinutes} min — Prix: {Prix}€");
        }

        // Règle location : 2.00€ + 3% du prix
        public decimal CalculateRent() => 2.00m + (0.03m * Prix);
    }
}
