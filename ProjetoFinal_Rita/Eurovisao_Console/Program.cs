using Eurovisao_BO;
using Eurovisao_BL;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR();

            //Adicionar concorrentes:
            if (!gestaoEurovisao.ImportarDados())
            {
                Eurovisao conc1 = gestaoEurovisao.NovoConcorrente("Suécia", "Loreen", "Tattoo", 340, 243, 583, 1);
                Eurovisao conc2 = gestaoEurovisao.NovoConcorrente("Finlândia", "Kaarija", "Cha Cha Cha", 150, 376, 526, 2);
                Eurovisao conc3 = gestaoEurovisao.NovoConcorrente("Israel", "Noa Kirel", "Unicorn", 177, 185, 362, 3);
                Eurovisao conc4 = gestaoEurovisao.NovoConcorrente("Itália", "Marco Mengoni", "Due Vite", 176, 174, 350, 4);
                Eurovisao conc5 = gestaoEurovisao.NovoConcorrente("Noruega", "Alessandra", "Queen of Kings", 52, 216, 268, 5);
                Eurovisao conc6 = gestaoEurovisao.NovoConcorrente("Ucrânia", "Tvorchi", "Heart of Steel", 54, 189, 243, 6);
                Eurovisao conc7 = gestaoEurovisao.NovoConcorrente("Bélgica", "Gustaph", "Because of You", 127, 55, 182, 7);
                Eurovisao conc8 = gestaoEurovisao.NovoConcorrente("Estónia", "Alika", "Bridges", 146, 22, 168, 8);
                Eurovisao conc9 = gestaoEurovisao.NovoConcorrente("Austrália", "Voyager", "Promise", 130, 21, 151, 9);
                Eurovisao conc10 = gestaoEurovisao.NovoConcorrente("Chéquia", "Vesna", "My Sister's Crown", 94, 35, 129, 10);
                Eurovisao conc11 = gestaoEurovisao.NovoConcorrente("Lituânia", "Monika Linkyté", "Stay", 81, 46, 127, 11);
                Eurovisao conc12 = gestaoEurovisao.NovoConcorrente("Chipre", "Andrew Lambrou", "Break a Broken Heart", 68, 58, 126, 12);
                Eurovisao conc13 = gestaoEurovisao.NovoConcorrente("Croácia", "Let 3", "Mama SC!", 11, 112, 123, 13);
                Eurovisao conc14 = gestaoEurovisao.NovoConcorrente("Arménia", "Brunette", "Future Lover", 69, 53, 122, 14);
                Eurovisao conc15 = gestaoEurovisao.NovoConcorrente("Austria", "Teya & Salena", "Mama SC!", 104, 16, 120, 15);
                Eurovisao conc16 = gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Mama SC!", 54, 50, 104, 16);
                Eurovisao conc17 = gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Mama SC!", 95, 5, 100, 17);
                Eurovisao conc18 = gestaoEurovisao.NovoConcorrente("Moldávia", "Pasha Parfeni", "Mama SC!", 20, 76, 96, 18);
                Eurovisao conc19 = gestaoEurovisao.NovoConcorrente("Polónia", "Blanka", "Mama SC!", 12, 81, 93, 19);
                Eurovisao conc20 = gestaoEurovisao.NovoConcorrente("Suiça", "Remo Forrer", "Mama SC!", 61, 31, 92, 20);
                Eurovisao conc21 = gestaoEurovisao.NovoConcorrente("Eslovénia", "Joker Out", "Mama SC!", 33, 45, 78, 21);
                Eurovisao conc22 = gestaoEurovisao.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", 17, 59, 76, 22);
                Eurovisao conc23 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 43, 16, 59, 23);
                Eurovisao conc24 = gestaoEurovisao.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", 14, 16, 30, 24);
                Eurovisao conc25 = gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", 15, 9, 24, 25);
                Eurovisao conc26 = gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", 3, 15, 18, 26);
            
                //Adicionar os concorrentes criados em cima à lista:
                gestaoEurovisao.AdicionarConcorrente(conc1);
                gestaoEurovisao.AdicionarConcorrente(conc2);
                gestaoEurovisao.AdicionarConcorrente(conc3);
                gestaoEurovisao.AdicionarConcorrente(conc4);
                gestaoEurovisao.AdicionarConcorrente(conc5);
                gestaoEurovisao.AdicionarConcorrente(conc6);
                gestaoEurovisao.AdicionarConcorrente(conc7);
                gestaoEurovisao.AdicionarConcorrente(conc8);
                gestaoEurovisao.AdicionarConcorrente(conc9);
                gestaoEurovisao.AdicionarConcorrente(conc10);
                gestaoEurovisao.AdicionarConcorrente(conc11);
                gestaoEurovisao.AdicionarConcorrente(conc12);
                gestaoEurovisao.AdicionarConcorrente(conc13);
                gestaoEurovisao.AdicionarConcorrente(conc14);
                gestaoEurovisao.AdicionarConcorrente(conc15);
                gestaoEurovisao.AdicionarConcorrente(conc16);
                gestaoEurovisao.AdicionarConcorrente(conc17);
                gestaoEurovisao.AdicionarConcorrente(conc18);
                gestaoEurovisao.AdicionarConcorrente(conc19);
                gestaoEurovisao.AdicionarConcorrente(conc20);
                gestaoEurovisao.AdicionarConcorrente(conc21);
                gestaoEurovisao.AdicionarConcorrente(conc22);
                gestaoEurovisao.AdicionarConcorrente(conc23);
                gestaoEurovisao.AdicionarConcorrente(conc24);
                gestaoEurovisao.AdicionarConcorrente(conc25);
                gestaoEurovisao.AdicionarConcorrente(conc26);
            }
            else
            {
                Console.WriteLine("Dados carregados!");
            }
            //Mostra lista de concorrentes da Eurovisão:
            Console.WriteLine("Lista dos concorrentes da Eurovisão:");
            Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList());
            Console.WriteLine();

            //Se quiser apagar concorrentes da lista:
            if (gestaoEurovisao.ApagarConcorrente("Portugal"))
            {
                Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            Console.WriteLine();
            Console.WriteLine("Listar os objetos:");
            Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList());

            Console.WriteLine();
            Console.WriteLine("A Serializar a lista...");
            gestaoEurovisao.ExportarDados();

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