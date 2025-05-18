using System;
using AdventureGame.Models.ArmeStrategy;

namespace AdventureGame.Models.Personnages
{
    public class Troll : Personnage
    {
        public override void Combattre()
        {
            Console.Write("Le troll attaque : ");
            arme?.UtiliserArme();
        }
    }
}