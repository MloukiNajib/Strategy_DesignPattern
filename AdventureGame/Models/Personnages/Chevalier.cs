using System;
using AdventureGame.Models.ArmeStrategy;

namespace AdventureGame.Models.Personnages
{
    public class Chevalier : Personnage
    {
        public override void Combattre()
        {
            Console.Write("Le chevalier attaque : ");
            arme?.UtiliserArme();
        }
    }
}