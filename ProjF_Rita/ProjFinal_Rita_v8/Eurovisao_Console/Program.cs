using Eurovisao_BO;
using Eurovisao_BL;
using Eurovisao_DAL;
using Eurovisao_Constantes;
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

            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR(); 

            Eurovisao s1f1 = gestaoEurovisao.NovoConcorrente("Finlândia", "Kaarija", "Cha Cha Cha", Enum.Parse<Ronda>("SemiFinal1"), 0, 177);
            Eurovisao s1f2 = gestaoEurovisao.NovoConcorrente("Suécia", "Loreen", "Tattoo", Enum.Parse<Ronda>("SemiFinal1"), 0, 135);
            Eurovisao s1f3 = gestaoEurovisao.NovoConcorrente("Israel", "Noa Kirel", "Unicorn", Enum.Parse<Ronda>("SemiFinal1"), 0, 127);
            Eurovisao s1f4 = gestaoEurovisao.NovoConcorrente("Chéquia", "Vesna", "My Sister's Crown", Enum.Parse<Ronda>("SemiFinal1"), 0, 110);
            Eurovisao s1f5 = gestaoEurovisao.NovoConcorrente("Moldávia", "Pasha Parfeni", "Soarale si Luna", Enum.Parse<Ronda>("SemiFinal1"), 0, 109);
            Eurovisao s1f6 = gestaoEurovisao.NovoConcorrente("Noruega", "Alessandra", "Queen of Kings", Enum.Parse<Ronda>("SemiFinal1"), 0, 102);
            Eurovisao s1f7 = gestaoEurovisao.NovoConcorrente("Suiça", "Remo Forrer", "Watergun", Enum.Parse<Ronda>("SemiFinal1"), 0, 97);
            Eurovisao s1f8 = gestaoEurovisao.NovoConcorrente("Croácia", "Let 3", "Mama SC!", Enum.Parse<Ronda>("SemiFinal1"), 0, 76);
            Eurovisao s1f9 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", Enum.Parse<Ronda>("SemiFinal1"), 0, 74);
            Eurovisao s1f10 = gestaoEurovisao.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", Enum.Parse<Ronda>("SemiFinal1"), 0, 37);
            Eurovisao s1f11 = gestaoEurovisao.NovoConcorrente("Letónia", "Sudden Lights", "Aijã", Enum.Parse<Ronda>("SemiFinal1"), 0, 34);
            Eurovisao s1f12 = gestaoEurovisao.NovoConcorrente("Irlanda", "Wild Youth", "We Are One", Enum.Parse<Ronda>("SemiFinal1"), 0, 10);
            Eurovisao s1f13 = gestaoEurovisao.NovoConcorrente("Países Baixos", "Mia Nicolai & Dion Cooper", "Burning Daylight", Enum.Parse<Ronda>("SemiFinal1"), 0, 7);
            Eurovisao s1f14 = gestaoEurovisao.NovoConcorrente("Azerbeijão", "TuralTuranX", "Tell Me More", Enum.Parse<Ronda>("SemiFinal1"), 0, 4);
            Eurovisao s1f15 = gestaoEurovisao.NovoConcorrente("Malta", "The Busker", "Dance (Our Own Party)", Enum.Parse<Ronda>("SemiFinal1"), 0, 3);

            if (!gestaoEurovisao.ImportarDados()) //adicionar concorrentes da semi final 1 à lista e importa os dados
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
                gestaoEurovisao.AdicionarConcorrente(s1f11);
                gestaoEurovisao.AdicionarConcorrente(s1f12);
                gestaoEurovisao.AdicionarConcorrente(s1f13);
                gestaoEurovisao.AdicionarConcorrente(s1f14);
                gestaoEurovisao.AdicionarConcorrente(s1f15);
            }
            else
            {
                Console.WriteLine("Dados já previamente carregados!");
            }

            /*--------------------------Mostra lista de concorrentes da primeira Semi-Final:-----------------------------------*/

            Console.WriteLine("----------------------Primeira Semi-Final da Eurovisão 2023----------------------");
            Console.WriteLine("\nLista dos concorrentes da primeira Semi-Final:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("SemiFinal1")));

            /*--------------------------Apagar os 5 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine($"\nA apagar os 5 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("\nLista atualizada: ");

            if (gestaoEurovisao.ApagarConcRonda(Enum.Parse<Ronda>("SemiFinal1"))) //apaga os 5 últimos concorrentes da lista
            {
                Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("SemiFinal1")));
            }
            else
            {
                Console.WriteLine("Concorrentes não encontrados, ou já eliminados.");
            }

            /*-------------------------------Lista dos concorrentes da segunda semi-final--------------------------------*/

            Eurovisao s2f1 = gestaoEurovisao.NovoConcorrente("Austrália", "Voyager", "Promise", Enum.Parse<Ronda>("SemiFinal2"), 0, 149);
            Eurovisao s2f2 = gestaoEurovisao.NovoConcorrente("Áustria", "Teya & Salena", "Who The Hell Is Edgar?", Enum.Parse<Ronda>("SemiFinal2"), 0, 137);
            Eurovisao s2f3 = gestaoEurovisao.NovoConcorrente("Polónia", "Blanka", "Solo", Enum.Parse<Ronda>("SemiFinal2"), 0, 124);
            Eurovisao s2f4 = gestaoEurovisao.NovoConcorrente("Lituânia", "Monika Linkyté", "Stay", Enum.Parse<Ronda>("SemiFinal2"), 0, 110);
            Eurovisao s2f5 = gestaoEurovisao.NovoConcorrente("Eslovénia", "Joker Out", "Carpe Diem", Enum.Parse<Ronda>("SemiFinal2"), 0, 103);
            Eurovisao s2f6 = gestaoEurovisao.NovoConcorrente("Arménia", "Brunette", "Future Lover", Enum.Parse<Ronda>("SemiFinal2"), 0, 99);
            Eurovisao s2f7 = gestaoEurovisao.NovoConcorrente("Chipre", "Andrew Lambrou", "Break a Broken Heart", Enum.Parse<Ronda>("SemiFinal2"), 0, 94);
            Eurovisao s2f8 = gestaoEurovisao.NovoConcorrente("Bélgica", "Gustaph", "Because of You", Enum.Parse<Ronda>("SemiFinal2"), 0, 90);
            Eurovisao s2f9 = gestaoEurovisao.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", Enum.Parse<Ronda>("SemiFinal2"), 0, 83);
            Eurovisao s2f10 = gestaoEurovisao.NovoConcorrente("Estónia", "Alika", "Bridges", Enum.Parse<Ronda>("SemiFinal2"), 0, 74);
            Eurovisao s2f11 = gestaoEurovisao.NovoConcorrente("Islândia", "Diljá", "Power", Enum.Parse<Ronda>("SemiFinal2"), 0, 44);
            Eurovisao s2f12 = gestaoEurovisao.NovoConcorrente("Geórgia", "Iru", "Echo", Enum.Parse<Ronda>("SemiFinal2"), 0, 33);
            Eurovisao s2f13 = gestaoEurovisao.NovoConcorrente("Grécia", "Victor Vernicos", "What They Say", Enum.Parse<Ronda>("SemiFinal2"), 0, 14);
            Eurovisao s2f14 = gestaoEurovisao.NovoConcorrente("Dinamarca", "Reiley", "Breaking My Heart", Enum.Parse<Ronda>("SemiFinal2"), 0, 6);
            Eurovisao s2f15 = gestaoEurovisao.NovoConcorrente("Roménia", "Theodor Andrei", "D.G.T. (Off and On)", Enum.Parse<Ronda>("SemiFinal2"), 0, 0);
            Eurovisao s2f16 = gestaoEurovisao.NovoConcorrente("San Marino", "Piqued Jacks", "Like An Animal", Enum.Parse<Ronda>("SemiFinal2"), 0, 0);

            if (!gestaoEurovisao.ImportarDados()) //adicionar concorrentes da semi final 2 à lista e importa os dados
            {
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
                gestaoEurovisao.AdicionarConcorrente(s2f11);
                gestaoEurovisao.AdicionarConcorrente(s2f12);
                gestaoEurovisao.AdicionarConcorrente(s2f13);
                gestaoEurovisao.AdicionarConcorrente(s2f14);
                gestaoEurovisao.AdicionarConcorrente(s2f15);
                gestaoEurovisao.AdicionarConcorrente(s2f16);
            }
            else
            {
                Console.WriteLine("Dados já previamente carregados!");
            }

            /*--------------------------Mostra lista de concorrentes da segunda Semi-Final:-----------------------------------*/

            Console.WriteLine("\n----------------------Segunda Semi-Final da Eurovisão 2023----------------------");
            Console.WriteLine("\nLista dos concorrentes da segunda Semi-Final:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("SemiFinal2")));

            /*--------------------------Apagar os 6 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine($"\nA apagar os 6 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("\nLista atualizada: ");

            if (gestaoEurovisao.ApagarConcRonda(Enum.Parse<Ronda>("SemiFinal2"))) //apaga os 6 últimos concorrentes da lista
            {
                Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("SemiFinal2")));
            }
            else
            {
                Console.WriteLine("Concorrentes não encontrados, ou já eliminados.");
            }

            /*-------------------------------Lista dos concorrentes da Final:-------------------------------------------*/

            Console.WriteLine("\n----------------------Final da Eurovisão 2023----------------------");
            Console.WriteLine($"\nA adicionar os países já qualificados para a final....");

            //Adicionar os concorrentes que já estavam automaticamente qualificados para a final:
            Eurovisao conc4 = gestaoEurovisao.NovoConcorrente("Itália", "Marco Mengoni", "Due Vite", Enum.Parse<Ronda>("Final"), 176, 174);
            Eurovisao conc6 = gestaoEurovisao.NovoConcorrente("Ucrânia", "Tvorchi", "Heart of Steel", Enum.Parse<Ronda>("Final"), 54, 189);
            Eurovisao conc16 = gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Évidemment", Enum.Parse<Ronda>("Final"), 54, 50);
            Eurovisao conc17 = gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Eaea", Enum.Parse<Ronda>("Final"), 95, 5);
            Eurovisao conc25 = gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", Enum.Parse<Ronda>("Final"), 15, 9);
            Eurovisao conc26 = gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", Enum.Parse<Ronda>("Final"), 3, 15);

            if (!gestaoEurovisao.ImportarDados())
            {
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

            /*--------------------------Alterar Ronda para final:--------------------------------------*/
            
            Console.WriteLine($"\nA alterar as rondas dos países das semi-finais qualificados para a final....");

            s1f1.Ronda = Enum.Parse<Ronda>("Final");
            s1f2.Ronda = Enum.Parse<Ronda>("Final");
            s1f3.Ronda = Enum.Parse<Ronda>("Final");
            s1f4.Ronda = Enum.Parse<Ronda>("Final");
            s1f5.Ronda = Enum.Parse<Ronda>("Final");
            s1f6.Ronda = Enum.Parse<Ronda>("Final");
            s1f7.Ronda = Enum.Parse<Ronda>("Final");
            s1f8.Ronda = Enum.Parse<Ronda>("Final");
            s1f9.Ronda = Enum.Parse<Ronda>("Final");
            s1f10.Ronda = Enum.Parse<Ronda>("Final");
            s2f1.Ronda = Enum.Parse<Ronda>("Final");
            s2f2.Ronda = Enum.Parse<Ronda>("Final");
            s2f3.Ronda = Enum.Parse<Ronda>("Final");
            s2f4.Ronda = Enum.Parse<Ronda>("Final");
            s2f5.Ronda = Enum.Parse<Ronda>("Final");
            s2f6.Ronda = Enum.Parse<Ronda>("Final");
            s2f7.Ronda = Enum.Parse<Ronda>("Final");
            s2f8.Ronda = Enum.Parse<Ronda>("Final");
            s2f9.Ronda = Enum.Parse<Ronda>("Final");
            s2f10.Ronda = Enum.Parse<Ronda>("Final");

            /*
            Console.WriteLine($"\nA alterar as rondas dos países das semi-finais qualificados para a final....");
            if (gestaoEurovisao.ExisteConcorrente(s1f1.Pais))
            {
                s1f1.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Finlândia", Enum.Parse <Ronda>("SemiFinal1"), s1f1);
                s1f2.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Suécia", Enum.Parse<Ronda>("SemiFinal1"), s1f2);
                s1f3.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Israel", Enum.Parse<Ronda>("SemiFinal1"), s1f3);
                s1f4.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Chéquia", Enum.Parse<Ronda>("SemiFinal1"), s1f4);
                s1f5.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Moldávia", Enum.Parse<Ronda>("SemiFinal1"), s1f5);
                s1f6.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Noruega", Enum.Parse<Ronda>("SemiFinal1"), s1f6);
                s1f7.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Suiça", Enum.Parse<Ronda>("SemiFinal1"), s1f7);
                s1f8.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Croácia", Enum.Parse<Ronda>("SemiFinal1"), s1f8);
                s1f9.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Portugal", Enum.Parse<Ronda>("SemiFinal1"), s1f9);
                s1f10.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Sériva", Enum.Parse<Ronda>("SemiFinal1"), s1f10);
                s2f1.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Austrália", Enum.Parse<Ronda>("SemiFinal2"), s2f1);
                s2f2.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Áustria", Enum.Parse<Ronda>("SemiFinal2"), s2f2);
                s2f3.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Polónia", Enum.Parse<Ronda>("SemiFinal2"), s2f3);
                s2f4.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Lituânia", Enum.Parse<Ronda>("SemiFinal2"), s2f4);
                s2f5.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Eslovénia", Enum.Parse<Ronda>("SemiFinal2"), s2f5);
                s2f6.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Arménia", Enum.Parse<Ronda>("SemiFinal2"), s2f6);
                s2f7.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Chipre", Enum.Parse<Ronda>("SemiFinal2"), s2f7);
                s2f8.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Bélgica", Enum.Parse<Ronda>("SemiFinal2"), s2f8);
                s2f9.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Albânia", Enum.Parse<Ronda>("SemiFinal2"), s2f9);
                s2f10.Ronda = Enum.Parse<Ronda>("Final");
                gestaoEurovisao.ModificarRondaConcorrente("Estónia", Enum.Parse<Ronda>("SemiFinal2"), s2f10);
            }
            else
            {
                Console.WriteLine("Concorrente não encontrado.");
            }
            */

            /*--------------------------Se quiser alterar Pontos do Júri:--------------------------------------*/

            Console.WriteLine($"\nA verificar a existência do país \"{s1f1.Pais}\", se existir, a alterar pontos do Júri de todas as músicas....");

            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID))
            {
                s1f1.PontosJuri = 150; // modificar os pontos do juri do s1f1 para 150
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
                //MostrarLista(gestaoEurovisao.GetConcorrentesList());
            }
            else 
            {
                Console.WriteLine("Concorrente não encontrado.");
            }
            
            /*--------------------------Se quiser alterar Pontos do Televoto:--------------------------------------*/

            Console.WriteLine($"\nA verificar a existência do pais \"{s1f1.Pais}\", se existir, a alterar pontos do Televoto de todas as músicas....");

            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID))
            {
                s1f1.PontosTelevoto = 376; //quero mudar os pontos televoto para 376
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
            }
            else 
            {
                Console.WriteLine("Concorrente não encontrado.");
            }

            /*--------------------------Mostra lista atualizada da Eurovisão:-----------------------------------*/

            Console.WriteLine("\nLista atualizada e ordenada por Total Pontos:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            gestaoEurovisao.OrdernarLista(); //ordena lista por total pontos
            MostrarLista(gestaoEurovisao.GetConcorrentesList());

            RegistoConcorrente vencedor = gestaoEurovisao.Vencedor(); //vai buscar o pais que tem maior total pontos
            Console.WriteLine($"\nVencedor da Eurovisão 2023: {vencedor.Pais}!!!");

            Console.WriteLine("\nA serializar a lista...");
            gestaoEurovisao.ExportarDados();

            Console.WriteLine("\nHistórico:\n");
            MostrarHistorico(gestaoEurovisao.Historico());
        }


        private static void MostrarLista(List<string> lista) //método responsável por mostrar a lista com todos os objetos (concorrentes)
        {
            foreach (var concorrente in lista)
            {
                Console.WriteLine(concorrente.ToString());
            }
        }
        private static void MostrarHistorico(List<string> historico) //método responsável por mostrar a lista com todos os objetos (concorrentes)
        {
            foreach (string entrada in historico)
            {
                Console.WriteLine(entrada);
            }
        }

    }
    }