using System;
using LesBases;
using LesBases.Test;
class Program
{
    static void Main()
    {
        // TestPremierTP.TestDuPremierTP();


        // TestSecondTP.Run();

        // Utilisation de l'indexeur
        // var test = new TestSecondTP();
        // test.articles.Add(new Livre("Livre 1", "Auteur 1", CategorieLivre.Poche, 12.0m));
        // test.articles.Add(new Livre("Livre 2", "Auteur 2", CategorieLivre.Broche, 15.0m));
        // test.articles.Add(new Disque("Disque 1", 45, 9.99m));
        // test.articles.Add(new Livre("Titre", "Auteur", CategorieLivre.Poche, 10.0m));
        // Console.WriteLine(test[3].Titre);
        
        new TestTroisiemeTP().Run();
    }
}