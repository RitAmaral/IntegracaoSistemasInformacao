using Eurovisao_BO;
using Eurovisao_BL;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine();
            Console.WriteLine("A serializar a lista...");
            gestaoEurovisao.ExportarDados();
            */

            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR();

            Eurovisao conc1 = gestaoEurovisao.NovoConcorrente("Suécia", "Loreen", "Tattoo", 340, 243, 1);
            Eurovisao conc2 = gestaoEurovisao.NovoConcorrente("Finlândia", "Kaarija", "Cha Cha Cha", 150, 376, 2);
            Eurovisao conc3 = gestaoEurovisao.NovoConcorrente("Israel", "Noa Kirel", "Unicorn", 177, 185, 3);
            Eurovisao conc4 = gestaoEurovisao.NovoConcorrente("Itália", "Marco Mengoni", "Due Vite", 176, 174, 4);
            Eurovisao conc5 = gestaoEurovisao.NovoConcorrente("Noruega", "Alessandra", "Queen of Kings", 52, 216, 5);
            Eurovisao conc6 = gestaoEurovisao.NovoConcorrente("Ucrânia", "Tvorchi", "Heart of Steel", 54, 189, 6);
            Eurovisao conc7 = gestaoEurovisao.NovoConcorrente("Bélgica", "Gustaph", "Because of You", 127, 55, 7);
            Eurovisao conc8 = gestaoEurovisao.NovoConcorrente("Estónia", "Alika", "Bridges", 146, 22, 8);
            Eurovisao conc9 = gestaoEurovisao.NovoConcorrente("Austrália", "Voyager", "Promise", 130, 21, 9);
            Eurovisao conc10 = gestaoEurovisao.NovoConcorrente("Chéquia", "Vesna", "My Sister's Crown", 94, 35, 10);
            Eurovisao conc11 = gestaoEurovisao.NovoConcorrente("Lituânia", "Monika Linkyté", "Stay", 81, 46, 11);
            Eurovisao conc12 = gestaoEurovisao.NovoConcorrente("Chipre", "Andrew Lambrou", "Break a Broken Heart", 68, 58, 12);
            Eurovisao conc13 = gestaoEurovisao.NovoConcorrente("Croácia", "Let 3", "Mama SC!", 11, 112, 13);
            Eurovisao conc14 = gestaoEurovisao.NovoConcorrente("Arménia", "Brunette", "Future Lover", 69, 53, 14);
            Eurovisao conc15 = gestaoEurovisao.NovoConcorrente("Austria", "Teya & Salena", "Mama SC!", 104, 16, 15);
            Eurovisao conc16 = gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Mama SC!", 54, 50, 16);
            Eurovisao conc17 = gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Mama SC!", 95, 5, 17);
            Eurovisao conc18 = gestaoEurovisao.NovoConcorrente("Moldávia", "Pasha Parfeni", "Mama SC!", 20, 76, 18);
            Eurovisao conc19 = gestaoEurovisao.NovoConcorrente("Polónia", "Blanka", "Mama SC!", 12, 81, 19);
            Eurovisao conc20 = gestaoEurovisao.NovoConcorrente("Suiça", "Remo Forrer", "Mama SC!", 61, 31, 20);
            Eurovisao conc21 = gestaoEurovisao.NovoConcorrente("Eslovénia", "Joker Out", "Mama SC!", 33, 45, 21);
            Eurovisao conc22 = gestaoEurovisao.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", 17, 59, 22);
            Eurovisao conc23 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 43, 16, 23);
            Eurovisao conc24 = gestaoEurovisao.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", 14, 16, 24);
            Eurovisao conc25 = gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", 15, 9, 25);
            Eurovisao conc26 = gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", 3, 15, 26);

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

            /*--------------------------Mostra lista de concorrentes da Eurovisão:-----------------------------------*/

            Console.WriteLine("Lista dos concorrentes da Eurovisão:");
            Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList());

            /*--------------------------Se quiser apagar concorrentes da lista:--------------------------------------*/
            
            Console.WriteLine("\nA apagar concorrentes....");
            Console.WriteLine("Lista atualizada: ");

            if (gestaoEurovisao.ApagarConcorrente("Portugal"))
            {
                Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            else
            {
                Console.WriteLine("Concorrente não encontrado.");
            }

            /*--------------------------Se quiser alterar Pontos do Juri:--------------------------------------*/

            if (gestaoEurovisao.ExisteConcorrente(conc1.ID))
            {
                Console.WriteLine($"\nA modificar os pontos do Juri do objeto com o id \"{conc1.ID}\"...");
                conc1.PontosJuri = 10; //quero mudar os pontos juri para 10
                gestaoEurovisao.ModificarPontosJuri(1, 10); //o novo1 tem o ID = 1, e vai passar para ID = 10
            }

            /*--------------------------Se quiser alterar Pontos do Televoto:--------------------------------------*/

            if (gestaoEurovisao.ExisteConcorrente(conc1.ID))
            {
                Console.WriteLine($"\nA modificar os pontos do Televoto do objeto com o id \"{conc1.ID}\"...");
                conc1.PontosTelevoto = 20; //quero mudar os pontos juri para 10
                gestaoEurovisao.ModificarPontosJuri(1, 20); //o novo1 tem o ID = 1, e vai passar para ID = 10
            }

            /*--------------------------Mostra lista atualizada da Eurovisão:-----------------------------------*/

            Console.WriteLine("Lista atualizada:");
            Console.WriteLine("ID\t|Pais\t|Representante\t|Musica\t|Juri\t|Televoto\t|Total Pontos\t|Classificação Final");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
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