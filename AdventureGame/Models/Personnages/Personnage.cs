namespace AdventureGame.Models.Personnages
{
    public abstract class Personnage : IPersonnage
    {
        protected IUtiliserArme? arme;

        public void SetArme(IUtiliserArme arme)
        {
            if(this.arme != null)
                Console.WriteLine(GetType().Name +" Change d'arme !");

            this.arme = arme;
        }

        public abstract void Combattre();
    }
}