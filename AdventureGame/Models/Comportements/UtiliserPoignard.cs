namespace AdventureGame.Models.Comportements
{
    public class UtiliserPoignard : IUtiliserArme
    {
        public void UtiliserArme()
        {
            Console.WriteLine("Je combats avec un poignard !");
        }
    }
}