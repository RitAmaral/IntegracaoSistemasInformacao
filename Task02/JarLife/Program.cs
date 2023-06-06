using JarLife.Entities;
using JarLife.Entities.Exception;

namespace JarLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Padrão de design Factory:

            try
            {
                FabricaJar fabrica = new FabricaJar();

                Jar golfballs = fabrica.CriarJar("GolfBalls");
                golfballs.Detalhes();
                Console.WriteLine();

                Jar pebbles = fabrica.CriarJar("Pebbles");
                pebbles.Detalhes();
                Console.WriteLine();

                Jar sand = fabrica.CriarJar("Sand");
                sand.Detalhes();
                Console.WriteLine();

                Jar brinquedo = fabrica.CriarJar("Brinquedo"); //usado para causar o erro
                brinquedo.Detalhes();
                Console.WriteLine();
            }
            
            catch (JarException e)
            {
                Console.WriteLine(e.Message);
            }


            //Padrão de design abstract:
            /*
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
            */

        }
    }
}