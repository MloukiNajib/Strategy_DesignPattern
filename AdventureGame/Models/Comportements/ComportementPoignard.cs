namespace AdventureGame.Models.Comportements
{
    public class ComportementPoignard : IComportementArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine("Je combats avec un poignard !");
        }
    }
}