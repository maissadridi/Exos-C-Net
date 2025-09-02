using System;

namespace LesBases
{
    public class Video : Publication, IRentable
    {
        public string Format { get; }

        public Video(string titre, string format, decimal prix)
            : base(titre, prix)
        {
            Format = format;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo: '{Titre}' — Format: {Format} — Prix: {Prix}€");
        }

        // Règle location : 2.50€ + 8% du prix
        public decimal CalculateRent() => 2.50m + (0.08m * Prix);
    }
}
