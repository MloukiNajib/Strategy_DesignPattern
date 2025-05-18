using AdventureGame.Models.Comportements;
using AdventureGame.Models.Personnages;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Début de combat !");

        Personnage roi = new Roi();
        roi.SetArme(new UtiliserPoignard());
        roi.Combattre();

        Personnage reine = new Reine();
        reine.SetArme(new UtiliserArcEtFleches());
        reine.Combattre();

        Personnage chevalier = new Chevalier();
        chevalier.SetArme(new UtiliserHache());
        chevalier.Combattre();

        Personnage troll = new Troll();
        troll.SetArme(new UtiliserHache());
        troll.Combattre();

        // Changement d’arme en cours de jeu
        roi.SetArme(new UtiliserArcEtFleches());
        roi.Combattre();

        System.Console.WriteLine("Fin de combat !");
        System.Console.ReadLine();
    }
}