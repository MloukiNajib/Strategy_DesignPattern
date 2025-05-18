namespace AdventureGame.Models.Comportements
{
    public class ComportementArcEtFleches : IComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine("Je combats avec un arc et des flèches !");
        }
    }
}