using AdventureGame.Models.Comportements;

namespace AdventureGame.Models
{
    public abstract class Personnage
    {
        protected IComportementArme? arme;

        public void SetArme(IComportementArme arme)
        {
            if(this.arme != null)
                Console.WriteLine(this.GetType().Name +" Change d'arme !");

            this.arme = arme;
        }

        public abstract void Combattre();
    }
}