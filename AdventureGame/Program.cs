using AdventureGame.Models.ArmeStrategy;
using AdventureGame.Models.Personnages;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Début de combat !");

        Personnage roi = new Roi();
        roi.SetArme(new Poignard());
        roi.Combattre();

        Personnage reine = new Reine();
        reine.SetArme(new ArcEtFleches());
        reine.Combattre();

        Personnage chevalier = new Chevalier();
        chevalier.SetArme(new Hache());
        chevalier.Combattre();

        Personnage troll = new Troll();
        troll.SetArme(new Hache());
        troll.Combattre();

        // Changement d’arme en cours de jeu
        roi.SetArme(new ArcEtFleches());
        roi.Combattre();

        System.Console.WriteLine("Fin de combat !");
        System.Console.ReadLine();
    }
}