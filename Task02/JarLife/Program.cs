using JarLife.Entities;

namespace JarLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GolfBalls golfBalls = new GolfBalls(5, 5, "saudável", "futebol, cantar, etc..");
            golfBalls.Detalhes();
            Console.WriteLine();

            Pebbles pebbles = new Pebbles("BMW", "Software Developer", 1);
            pebbles.Detalhes();
            Console.WriteLine();

            Sand sand = new Sand("Sim", "Não");
            sand.Detalhes();
            Console.WriteLine();

        }
    }
}