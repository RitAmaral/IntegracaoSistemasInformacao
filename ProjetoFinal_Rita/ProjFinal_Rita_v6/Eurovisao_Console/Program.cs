using Eurovisao_BO;
using Eurovisao_BL;
using Eurovisao_DAL;
using System.Reflection;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM-VINDO À EUROVISÃO 2023!");
            Console.WriteLine("----------------------------\n");

            /*-------------------------------Lista dos concorrentes da primeira semi-final--------------------------------*/

            Eurovisao_BR gestaoSemi1 = new Eurovisao_BR(); //nota: falta importar dados

            Eurovisao s1f1 = gestaoSemi1.NovoConcorrente("Finlândia", "Kaarija", "Cha Cha Cha", 0, 177);
            Eurovisao s1f2 = gestaoSemi1.NovoConcorrente("Suécia", "Loreen", "Tattoo", 0, 135);
            Eurovisao s1f3 = gestaoSemi1.NovoConcorrente("Israel", "Noa Kirel", "Unicorn", 0, 127);
            Eurovisao s1f4 = gestaoSemi1.NovoConcorrente("Chéquia", "Vesna", "My Sister's Crown", 0, 110);
            Eurovisao s1f5 = gestaoSemi1.NovoConcorrente("Moldávia", "Pasha Parfeni", "Soarale si Luna", 0, 109);
            Eurovisao s1f6 = gestaoSemi1.NovoConcorrente("Noruega", "Alessandra", "Queen of Kings", 0, 102);
            Eurovisao s1f7 = gestaoSemi1.NovoConcorrente("Suiça", "Remo Forrer", "Watergun", 0, 97);
            Eurovisao s1f8 = gestaoSemi1.NovoConcorrente("Croácia", "Let 3", "Mama SC!", 0, 76);
            Eurovisao s1f9 = gestaoSemi1.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 0, 74);
            Eurovisao s1f10 = gestaoSemi1.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", 0, 37);
            Eurovisao s1f11 = gestaoSemi1.NovoConcorrente("Letónia", "Sudden Lights", "Aijã", 0, 34);
            Eurovisao s1f12 = gestaoSemi1.NovoConcorrente("Irlanda", "Wild Youth", "We Are One", 0, 10);
            Eurovisao s1f13 = gestaoSemi1.NovoConcorrente("Países Baixos", "Mia Nicolai & Dion Cooper", "Burning Daylight", 0, 7);
            Eurovisao s1f14 = gestaoSemi1.NovoConcorrente("Azerbeijão", "TuralTuranX", "Tell Me More", 0, 4);
            Eurovisao s1f15 = gestaoSemi1.NovoConcorrente("Malta", "The Busker", "Dance (Our Own Party)", 0, 3);

            if (!gestaoSemi1.ImportarDados()) //adicionar concorrentes da semi final 1 à lista e importa os dados
            {
                gestaoSemi1.AdicionarConcorrente(s1f1);
                gestaoSemi1.AdicionarConcorrente(s1f2);
                gestaoSemi1.AdicionarConcorrente(s1f3);
                gestaoSemi1.AdicionarConcorrente(s1f4);
                gestaoSemi1.AdicionarConcorrente(s1f5);
                gestaoSemi1.AdicionarConcorrente(s1f6);
                gestaoSemi1.AdicionarConcorrente(s1f7);
                gestaoSemi1.AdicionarConcorrente(s1f8);
                gestaoSemi1.AdicionarConcorrente(s1f9);
                gestaoSemi1.AdicionarConcorrente(s1f10);
                gestaoSemi1.AdicionarConcorrente(s1f11);
                gestaoSemi1.AdicionarConcorrente(s1f12);
                gestaoSemi1.AdicionarConcorrente(s1f13);
                gestaoSemi1.AdicionarConcorrente(s1f14);
                gestaoSemi1.AdicionarConcorrente(s1f15);
            }
            else
            {
                Console.WriteLine("Dados já previamente carregados!");
            }

            /*--------------------------Mostra lista de concorrentes da primeira Semi-Final:-----------------------------------*/

            Console.WriteLine("Lista dos concorrentes da primeira Semi-Final:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoSemi1.GetConcorrentesList());

            /*--------------------------Apagar os 5 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine($"\nA apagar os 5 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("Lista atualizada: ");

            if (gestaoSemi1.ApagarConcClassificacaoFinal()) //apaga os 5 últimos concorrentes da lista
            {
                Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoSemi1.GetConcorrentesList());
            }
            else
            {
                Console.WriteLine("Concorrentes não encontrados, ou já eliminados.");
            }

            /*-------------------------------Lista dos concorrentes da segunda semi-final--------------------------------*/

            Eurovisao_BR gestaoSemi2 = new Eurovisao_BR();

            Eurovisao s2f1 = gestaoSemi2.NovoConcorrente("Austrália", "Voyager", "Promise", 0, 149);
            Eurovisao s2f2 = gestaoSemi2.NovoConcorrente("Áustria", "Teya & Salena", "Who The Hell Is Edgar?", 0, 137);
            Eurovisao s2f3 = gestaoSemi2.NovoConcorrente("Polónia", "Blanka", "Solo", 0, 124);
            Eurovisao s2f4 = gestaoSemi2.NovoConcorrente("Lituânia", "Monika Linkyté", "Stay", 0, 110);
            Eurovisao s2f5 = gestaoSemi2.NovoConcorrente("Eslovénia", "Joker Out", "Carpe Diem", 0, 103);
            Eurovisao s2f6 = gestaoSemi2.NovoConcorrente("Arménia", "Brunette", "Future Lover", 0, 99);
            Eurovisao s2f7 = gestaoSemi2.NovoConcorrente("Chipre", "Andrew Lambrou", "Break a Broken Heart", 0, 94);
            Eurovisao s2f8 = gestaoSemi2.NovoConcorrente("Bélgica", "Gustaph", "Because of You", 0, 90);
            Eurovisao s2f9 = gestaoSemi2.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", 0, 83);
            Eurovisao s2f10 = gestaoSemi2.NovoConcorrente("Estónia", "Alika", "Bridges", 0, 74);
            Eurovisao s2f11 = gestaoSemi2.NovoConcorrente("Islândia", "Diljá", "Power", 0, 44);
            Eurovisao s2f12 = gestaoSemi2.NovoConcorrente("Geórgia", "Iru", "Echo", 0, 33);
            Eurovisao s2f13 = gestaoSemi2.NovoConcorrente("Grécia", "Victor Vernicos", "What They Say", 0, 14);
            Eurovisao s2f14 = gestaoSemi2.NovoConcorrente("Dinamarca", "Reiley", "Breaking My Heart", 0, 6);
            Eurovisao s2f15 = gestaoSemi2.NovoConcorrente("Roménia", "Theodor Andrei", "D.G.T. (Off and On)", 0, 0);
            Eurovisao s2f16 = gestaoSemi2.NovoConcorrente("San Marino", "Piqued Jacks", "Like An Animal", 0, 0);

            if (!gestaoSemi2.ImportarDados()) //adicionar concorrentes da semi final 2 à lista e importa os dados
            {
                gestaoSemi2.AdicionarConcorrente(s2f1);
                gestaoSemi2.AdicionarConcorrente(s2f2);
                gestaoSemi2.AdicionarConcorrente(s2f3);
                gestaoSemi2.AdicionarConcorrente(s2f4);
                gestaoSemi2.AdicionarConcorrente(s2f5);
                gestaoSemi2.AdicionarConcorrente(s2f6);
                gestaoSemi2.AdicionarConcorrente(s2f7);
                gestaoSemi2.AdicionarConcorrente(s2f8);
                gestaoSemi2.AdicionarConcorrente(s2f9);
                gestaoSemi2.AdicionarConcorrente(s2f10);
                gestaoSemi2.AdicionarConcorrente(s2f11);
                gestaoSemi2.AdicionarConcorrente(s2f12);
                gestaoSemi2.AdicionarConcorrente(s2f13);
                gestaoSemi2.AdicionarConcorrente(s2f14);
                gestaoSemi2.AdicionarConcorrente(s2f15);
                gestaoSemi2.AdicionarConcorrente(s2f16);
            }
            else
            {
                Console.WriteLine("Dados já previamente carregados!");
            }

            /*--------------------------Mostra lista de concorrentes da segunda Semi-Final:-----------------------------------*/

            Console.WriteLine("\nLista dos concorrentes da segunda Semi-Final:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoSemi2.GetConcorrentesList());

            /*--------------------------Apagar os 5 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine($"\nA apagar os 6 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("Lista atualizada: ");

            if (gestaoSemi2.ApagarConcClassificacaoFinal()) //apaga os 6 últimos concorrentes da lista
            {
                Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoSemi2.GetConcorrentesList());
            }
            else
            {
                Console.WriteLine("Concorrentes não encontrados, ou já eliminados.");
            }

            /*-------------------------------Lista dos concorrentes da final-------------------------------------------*/

            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR();

            //Adicionar os concorrentes que já estavam automaticamente qualificados para a final:
            Eurovisao conc4 = gestaoEurovisao.NovoConcorrente("Itália", "Marco Mengoni", "Due Vite", 176, 174);
            Eurovisao conc6 = gestaoEurovisao.NovoConcorrente("Ucrânia", "Tvorchi", "Heart of Steel", 54, 189);
            Eurovisao conc16 = gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Évidemment", 54, 50);
            Eurovisao conc17 = gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Eaea", 95, 5);
            Eurovisao conc25 = gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", 15, 9);
            Eurovisao conc26 = gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", 3, 15);

            if (!gestaoEurovisao.ImportarDados())
            {
                gestaoEurovisao.AdicionarConcorrente(s1f1);
                gestaoEurovisao.AdicionarConcorrente(s1f2);
                gestaoEurovisao.AdicionarConcorrente(s1f3);
                gestaoEurovisao.AdicionarConcorrente(s1f4);
                gestaoEurovisao.AdicionarConcorrente(s1f5);
                gestaoEurovisao.AdicionarConcorrente(s1f6);
                gestaoEurovisao.AdicionarConcorrente(s1f7);
                gestaoEurovisao.AdicionarConcorrente(s1f8);
                gestaoEurovisao.AdicionarConcorrente(s1f9);
                gestaoEurovisao.AdicionarConcorrente(s1f10);

                gestaoEurovisao.AdicionarConcorrente(s2f1);
                gestaoEurovisao.AdicionarConcorrente(s2f2);
                gestaoEurovisao.AdicionarConcorrente(s2f3);
                gestaoEurovisao.AdicionarConcorrente(s2f4);
                gestaoEurovisao.AdicionarConcorrente(s2f5);
                gestaoEurovisao.AdicionarConcorrente(s2f6);
                gestaoEurovisao.AdicionarConcorrente(s2f7);
                gestaoEurovisao.AdicionarConcorrente(s2f8);
                gestaoEurovisao.AdicionarConcorrente(s2f9);
                gestaoEurovisao.AdicionarConcorrente(s2f10);

                gestaoEurovisao.AdicionarConcorrente(conc4);
                gestaoEurovisao.AdicionarConcorrente(conc6);
                gestaoEurovisao.AdicionarConcorrente(conc16);
                gestaoEurovisao.AdicionarConcorrente(conc17);
                gestaoEurovisao.AdicionarConcorrente(conc25);
                gestaoEurovisao.AdicionarConcorrente(conc26);
            }
            else
            {
                Console.WriteLine("Dados já previamente carregados!");
            }

            /*
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
            Eurovisao conc15 = gestaoEurovisao.NovoConcorrente("Áustria", "Teya & Salena", "Who The Hell Is Edgar?", 104, 16, 15);
            Eurovisao conc16 = gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Évidemment", 54, 50, 16);
            Eurovisao conc17 = gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Eaea", 95, 5, 17);
            Eurovisao conc18 = gestaoEurovisao.NovoConcorrente("Moldávia", "Pasha Parfeni", "Soarale si Luna", 20, 76, 18);
            Eurovisao conc19 = gestaoEurovisao.NovoConcorrente("Polónia", "Blanka", "Solo", 12, 81, 19);
            Eurovisao conc20 = gestaoEurovisao.NovoConcorrente("Suiça", "Remo Forrer", "Watergun", 61, 31, 20);
            Eurovisao conc21 = gestaoEurovisao.NovoConcorrente("Eslovénia", "Joker Out", "Carpe Diem", 33, 45, 21);
            Eurovisao conc22 = gestaoEurovisao.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", 17, 59, 22);
            Eurovisao conc23 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", 43, 16, 23);
            Eurovisao conc24 = gestaoEurovisao.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", 14, 16, 24);
            Eurovisao conc25 = gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", 15, 9, 25);
            Eurovisao conc26 = gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", 3, 15, 26);
            */

            /*--------------------------Mostra lista de concorrentes da Eurovisão:-----------------------------------*/

            Console.WriteLine("\nLista dos concorrentes da Final da Eurovisão 2023:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList());

            /*--------------------------Se quiser apagar concorrentes da lista:--------------------------------------*/

            /*
            Console.WriteLine($"\nA apagar concorrente \"{conc23.Pais}\"...");
            Console.WriteLine("Lista atualizada: ");

            if (gestaoEurovisao.ApagarConcorrente("Portugal"))
            {
                Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos\t|Classificação Final");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            else
            {
                Console.WriteLine("Concorrente não encontrado, possivelmente já eliminado.");
            }
            */

            /*--------------------------Se quiser alterar Pontos do Júri:--------------------------------------*/
            
            Console.WriteLine($"\nA verificar a existência do país \"{s1f1.Pais}\"...");

            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID))
            {
                Console.WriteLine($"\nA modificar os pontos do Júri das músicas...");
                s1f1.PontosJuri = 150; // modificar os pontos do juri conc1 para 15
                gestaoEurovisao.ModificarPontosJuri(0, s1f1);  //aqui coloco os pontos do júri antigos
                s1f2.PontosJuri = 340; 
                gestaoEurovisao.ModificarPontosJuri(0, s1f2);
                s1f3.PontosJuri = 177;
                gestaoEurovisao.ModificarPontosJuri(0, s1f3);
                s1f4.PontosJuri = 94;
                gestaoEurovisao.ModificarPontosJuri(0, s1f4);
                s1f5.PontosJuri = 20;
                gestaoEurovisao.ModificarPontosJuri(0, s1f5);
                s1f6.PontosJuri = 52;
                gestaoEurovisao.ModificarPontosJuri(0, s1f6);
                s1f7.PontosJuri = 61;
                gestaoEurovisao.ModificarPontosJuri(0, s1f7);
                s1f8.PontosJuri = 11;
                gestaoEurovisao.ModificarPontosJuri(0, s1f8);
                s1f9.PontosJuri = 43;
                gestaoEurovisao.ModificarPontosJuri(0, s1f9);
                s1f10.PontosJuri = 14;
                gestaoEurovisao.ModificarPontosJuri(0, s1f10);
                s2f1.PontosJuri = 130; 
                gestaoEurovisao.ModificarPontosJuri(0, s2f1);
                s2f2.PontosJuri = 104;
                gestaoEurovisao.ModificarPontosJuri(0, s2f2);
                s2f3.PontosJuri = 12;
                gestaoEurovisao.ModificarPontosJuri(0, s2f3);
                s2f4.PontosJuri = 81;
                gestaoEurovisao.ModificarPontosJuri(0, s2f4);
                s2f5.PontosJuri = 33;
                gestaoEurovisao.ModificarPontosJuri(0, s2f5);
                s2f6.PontosJuri = 69;
                gestaoEurovisao.ModificarPontosJuri(0, s2f6);
                s2f7.PontosJuri = 68;
                gestaoEurovisao.ModificarPontosJuri(0, s2f7);
                s2f8.PontosJuri = 127;
                gestaoEurovisao.ModificarPontosJuri(0, s2f8);
                s2f9.PontosJuri = 17;
                gestaoEurovisao.ModificarPontosJuri(0, s2f9);
                s2f10.PontosJuri = 146;
                gestaoEurovisao.ModificarPontosJuri(0, s2f10);
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            else /* ---------------------------------nota: não está a ser atualizada a classificação final---------------------------------------*/
            {
                Console.WriteLine("Concorrente não encontrado.");
            }
            
            /*--------------------------Se quiser alterar Pontos do Televoto:--------------------------------------*/

            Console.WriteLine();
            Console.WriteLine($"A verificar a existência do pais \"{s1f1.Pais}\"...");

            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID))
            {
                Console.WriteLine($"\nA modificar os pontos do Televoto das músicas...");
                s1f1.PontosTelevoto = 376; //quero mudar os pontos televoto para 20
                gestaoEurovisao.ModificarPontosTelevoto(177, s1f1); //aqui coloca os pontos de televoto antigos
                s1f2.PontosTelevoto = 243;
                gestaoEurovisao.ModificarPontosTelevoto(135, s1f2);
                s1f3.PontosTelevoto = 185;
                gestaoEurovisao.ModificarPontosTelevoto(127, s1f3);
                s1f4.PontosTelevoto = 35;
                gestaoEurovisao.ModificarPontosTelevoto(110, s1f4);
                s1f5.PontosTelevoto = 76;
                gestaoEurovisao.ModificarPontosTelevoto(109, s1f5);
                s1f6.PontosTelevoto = 216;
                gestaoEurovisao.ModificarPontosTelevoto(102, s1f6);
                s1f7.PontosTelevoto = 31;
                gestaoEurovisao.ModificarPontosTelevoto(97, s1f7);
                s1f8.PontosTelevoto = 112;
                gestaoEurovisao.ModificarPontosTelevoto(76, s1f8);
                s1f9.PontosTelevoto = 16;
                gestaoEurovisao.ModificarPontosTelevoto(74, s1f9);
                s1f10.PontosTelevoto = 16;
                gestaoEurovisao.ModificarPontosTelevoto(37, s1f10);
                s2f1.PontosTelevoto = 21;
                gestaoEurovisao.ModificarPontosTelevoto(149, s2f1);
                s2f2.PontosTelevoto = 16;
                gestaoEurovisao.ModificarPontosTelevoto(137, s2f2);
                s2f3.PontosTelevoto = 81;
                gestaoEurovisao.ModificarPontosTelevoto(124, s2f3);
                s2f4.PontosTelevoto = 46;
                gestaoEurovisao.ModificarPontosTelevoto(110, s2f4);
                s2f5.PontosTelevoto = 45;
                gestaoEurovisao.ModificarPontosTelevoto(103, s2f5);
                s2f6.PontosTelevoto = 53;
                gestaoEurovisao.ModificarPontosTelevoto(99, s2f6);
                s2f7.PontosTelevoto = 58;
                gestaoEurovisao.ModificarPontosTelevoto(94, s2f7);
                s2f8.PontosTelevoto = 55;
                gestaoEurovisao.ModificarPontosTelevoto(90, s2f8);
                s2f9.PontosTelevoto = 59;
                gestaoEurovisao.ModificarPontosTelevoto(83, s2f9);
                s2f10.PontosTelevoto = 22;
                gestaoEurovisao.ModificarPontosTelevoto(74, s2f10);
                MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            else /* ---------------------------------nota: não está a ser atualizada a classificação final---------------------------------------*/
            {
                Console.WriteLine("Concorrente não encontrado.");
            }

            /*--------------------------Mostra lista atualizada da Eurovisão:-----------------------------------*/

            Console.WriteLine("\nLista atualizada e ordenada por Total Pontos:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            gestaoEurovisao.OrdernarLista();
            MostrarLista(gestaoEurovisao.GetConcorrentesList());

            RegistoConcorrente vencedor = gestaoEurovisao.Vencedor();
            Console.WriteLine($"\nVencedor da Eurovisão 2023: {vencedor.Pais}!!!");

            Console.WriteLine("\nA serializar a lista...");
            gestaoEurovisao.ExportarDados();

        }
        private static void MostrarLista(List<string> lista) //método responsável por mostrar a lista com todos os objetos (concorrentes)
        {
            foreach (var concorrente in lista)
            {
                Console.WriteLine(concorrente.ToString());
            }
        }

    }
    }