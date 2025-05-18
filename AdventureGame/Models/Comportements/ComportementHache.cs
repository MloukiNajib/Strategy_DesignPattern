namespace AdventureGame.Models.Comportements
{
    public class ComportementHache : IComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine("Je combats avec une hache !");
        }
    }
}