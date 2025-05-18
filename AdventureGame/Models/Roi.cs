using System;
using AdventureGame.Models.Comportements;

namespace AdventureGame.Models
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