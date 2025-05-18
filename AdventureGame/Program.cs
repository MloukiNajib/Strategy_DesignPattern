using AdventureGame.Models;
using AdventureGame.Models.Comportements;

class Program
{
    static void Main(string[] args)
    {
        Personnage roi = new Roi();
        roi.SetArme(new ComportementPoignard());
        roi.Combattre();

        Personnage reine = new Reine();
        reine.SetArme(new ComportementArcEtFleches());
        reine.Combattre();

        Personnage chevalier = new Chevalier();
        chevalier.SetArme(new ComportementHache());
        chevalier.Combattre();

        Personnage troll = new Troll();
        troll.SetArme(new ComportementHache());
        troll.Combattre();

        // Changement d’arme en cours de jeu
        roi.SetArme(new ComportementArcEtFleches());
        roi.Combattre();
    }
}