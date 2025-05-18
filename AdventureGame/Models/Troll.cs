using System;
using AdventureGame.Models.Comportements;

namespace AdventureGame.Models
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