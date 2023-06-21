using Eurovisao_BO;
using Eurovisao_BL;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR();

            Console.WriteLine("ID\t|Pais\t|Nome Representante\t|Nome Musica\t|Pontos Juri\t|Pontos Televoto\t|Total Pontos\t|Classificação Final");

            Eurovisao pais1 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 43, 16, 23);
            gestaoEurovisao.AdicionarConcorrente(pais1);

            MostrarLista(gestaoEurovisao.GetConcorrentesList());
            if (gestaoEurovisao.ApagarConcorrente("Portugal"))
                Console.WriteLine("ID\t|Pais\t|Nome Representante\t|Nome Musica\t|Pontos Juri\t|Pontos Televoto\t|Total Pontos\t|Classificação Final");
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
        }
        private static void MostrarLista(List<string> lista)
        {
            foreach (var concorrente in lista)
            {
                Console.WriteLine(concorrente.ToString());
            }
        }
    }
}