using Eurovisao_BO;
using Eurovisao_BL;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR();

            Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");

            //Adicionar concorrentes:
            Eurovisao conc1 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 43, 16, 23);
            Eurovisao conc2 = gestaoEurovisao.NovoConcorrente("Suécia", "Loreen", "Tattoo", 340, 243, 1);

            //Adicionar os concorrentes criados em cima à lista:
            gestaoEurovisao.AdicionarConcorrente(conc1);
            gestaoEurovisao.AdicionarConcorrente(conc2);

            //Mostra lista de concorrentes da Eurovisão:
            MostrarLista(gestaoEurovisao.GetConcorrentesList());
            Console.WriteLine();

            //Se quiser apagar concorrentes da lista:
            if (gestaoEurovisao.ApagarConcorrente("Portugal"))
                Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
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