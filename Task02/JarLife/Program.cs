using JarLife.Entities;

namespace JarLife
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GolfBalls golfBalls = new GolfBalls("Alex", DateOnly.Parse("01/01/2000"), "português", "masculino", 5, 5, "saudável", "futebol, cantar, etc..");
            golfBalls.MostrarDetalhes();
            Console.WriteLine();
            golfBalls.Detalhes();
            Console.WriteLine();

            Pebbles pebbles = new Pebbles("Alex", DateOnly.Parse("01/01/2000"), "Português", "Masculino", "BMW", "Software Developer", 1);
            pebbles.Detalhes();
            Console.WriteLine();

            Sand sand = new Sand("Alex", DateOnly.Parse("01/01/2000"), "Português", "Masculino", "Sim", "Não");
            sand.Detalhes();
            Console.WriteLine();

        }
    }
}