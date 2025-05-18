using System;
using AdventureGame.Models.ArmeStrategy;

namespace AdventureGame.Models.Personnages
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