using System;
using AdventureGame.Models.ArmeStrategy;

namespace AdventureGame.Models.Personnages
{
    public class Roi : Personnage
    {
        public override void Combattre()
        {
            Console.Write("Le roi attaque : ");
            arme?.UtiliserArme();
        }
    }
}