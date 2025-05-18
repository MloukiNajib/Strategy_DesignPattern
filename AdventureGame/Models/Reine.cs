using System;
using AdventureGame.Models.Comportements;

namespace AdventureGame.Models
{
    public class Reine : Personnage
    {
        public override void Combattre()
        {
            Console.Write("La reine attaque : ");
            arme?.UtiliserArme();
        }
    }
}