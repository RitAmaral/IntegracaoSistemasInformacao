using Eurovisao_BOpg;
using Eurovisao_BLpg;
using Eurovisao_Constantes;
using System.Reflection;

namespace Eurovisao_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota: Antes de começar, aconselho que primeiro seja compilada a solução: WinFormsApp, para ler um pouco sobre a Eurovisão");
            Console.WriteLine("\nBEM-VINDO À EUROVISÃO 2023!");
            Console.WriteLine("----------------------------\n");

            /*-------------------------------Lista dos concorrentes da primeira semifinal--------------------------------*/

            Eurovisao_BR gestaoEurovisao = new Eurovisao_BR(); //criar lista gestaoEurovisao

            Eurovisao s1f1 = gestaoEurovisao.NovoConcorrente("Finlândia", "Kaarija", "Cha Cha Cha", Enum.Parse<Ronda>("Semifinal1"), 0, 177);

            Console.WriteLine("... A verificar os dados na BD ...");

            VerificarAdiciona(gestaoEurovisao, s1f1);

            Eurovisao s1f2 = gestaoEurovisao.NovoConcorrente("Suécia", "Loreen", "Tattoo", Enum.Parse<Ronda>("Semifinal1"), 0, 135);
            Eurovisao s1f3 = gestaoEurovisao.NovoConcorrente("Israel", "Noa Kirel", "Unicorn", Enum.Parse<Ronda>("Semifinal1"), 0, 127);
            Eurovisao s1f4 = gestaoEurovisao.NovoConcorrente("Chéquia", "Vesna", "My Sister's Crown", Enum.Parse<Ronda>("Semifinal1"), 0, 110);
            Eurovisao s1f5 = gestaoEurovisao.NovoConcorrente("Moldávia", "Pasha Parfeni", "Soarale si Luna", Enum.Parse<Ronda>("Semifinal1"), 0, 109);
            Eurovisao s1f6 = gestaoEurovisao.NovoConcorrente("Noruega", "Alessandra", "Queen of Kings", Enum.Parse<Ronda>("Semifinal1"), 0, 102);
            Eurovisao s1f7 = gestaoEurovisao.NovoConcorrente("Suiça", "Remo Forrer", "Watergun", Enum.Parse<Ronda>("Semifinal1"), 0, 97);
            Eurovisao s1f8 = gestaoEurovisao.NovoConcorrente("Croácia", "Let 3", "Mama SC!", Enum.Parse<Ronda>("Semifinal1"), 0, 76);
            Eurovisao s1f9 = gestaoEurovisao.NovoConcorrente("Portugal", "Mimicat", "Ai Coração", Enum.Parse<Ronda>("Semifinal1"), 0, 74);
            Eurovisao s1f10 = gestaoEurovisao.NovoConcorrente("Sérvia", "Luke Black", "Samo mi se spava", Enum.Parse<Ronda>("Semifinal1"), 0, 37);
            Eurovisao s1f11 = gestaoEurovisao.NovoConcorrente("Letónia", "Sudden Lights", "Aijã", Enum.Parse<Ronda>("Semifinal1"), 0, 34);
            Eurovisao s1f12 = gestaoEurovisao.NovoConcorrente("Irlanda", "Wild Youth", "We Are One", Enum.Parse<Ronda>("Semifinal1"), 0, 10);
            Eurovisao s1f13 = gestaoEurovisao.NovoConcorrente("Países Baixos", "Mia Nicolai & Dion Cooper", "Burning Daylight", Enum.Parse<Ronda>("Semifinal1"), 0, 7);
            Eurovisao s1f14 = gestaoEurovisao.NovoConcorrente("Azerbeijão", "TuralTuranX", "Tell Me More", Enum.Parse<Ronda>("Semifinal1"), 0, 4);
            Eurovisao s1f15 = gestaoEurovisao.NovoConcorrente("Malta", "The Busker", "Dance (Our Own Party)", Enum.Parse<Ronda>("Semifinal1"), 0, 3);

            VerificarAdiciona(gestaoEurovisao, s1f2);
            VerificarAdiciona(gestaoEurovisao, s1f3);
            VerificarAdiciona(gestaoEurovisao, s1f4);
            VerificarAdiciona(gestaoEurovisao, s1f5);
            VerificarAdiciona(gestaoEurovisao, s1f6);
            VerificarAdiciona(gestaoEurovisao, s1f7);
            VerificarAdiciona(gestaoEurovisao, s1f8);
            VerificarAdiciona(gestaoEurovisao, s1f9);
            VerificarAdiciona(gestaoEurovisao, s1f10);
            VerificarAdiciona(gestaoEurovisao, s1f11);
            VerificarAdiciona(gestaoEurovisao, s1f12);
            VerificarAdiciona(gestaoEurovisao, s1f13);
            VerificarAdiciona(gestaoEurovisao, s1f14);
            VerificarAdiciona(gestaoEurovisao, s1f15);


            /*--------------------------Mostra lista de concorrentes da primeira Semi-Final:-----------------------------------*/

            Console.WriteLine("----------------------Primeira Semifinal da Eurovisão 2023----------------------");
            Console.WriteLine("\nLista dos concorrentes da primeira Semifinal:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("Semifinal1")));

            /*--------------------------Apagar os 5 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine("\nInfelizmente, apenas 10 países da primeira Semifinal passam para a grande Final, por isso, vão ser apagados os 5 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("\nLista atualizada: ");

            gestaoEurovisao.ApagarConcorrente("Letónia");
            gestaoEurovisao.ApagarConcorrente("Irlanda");
            gestaoEurovisao.ApagarConcorrente("Países Baixos");
            gestaoEurovisao.ApagarConcorrente("Azerbeijão");
            gestaoEurovisao.ApagarConcorrente("Malta");

            //MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("Semifinal1")));


            /*-------------------------------Lista dos concorrentes da segunda semifinal--------------------------------*/


            Eurovisao s2f1 = gestaoEurovisao.NovoConcorrente("Austrália", "Voyager", "Promise", Enum.Parse<Ronda>("Semifinal2"), 0, 149);
            Eurovisao s2f2 = gestaoEurovisao.NovoConcorrente("Áustria", "Teya & Salena", "Who The Hell Is Edgar?", Enum.Parse<Ronda>("Semifinal2"), 0, 137);
            Eurovisao s2f3 = gestaoEurovisao.NovoConcorrente("Polónia", "Blanka", "Solo", Enum.Parse<Ronda>("Semifinal2"), 0, 124);
            Eurovisao s2f4 = gestaoEurovisao.NovoConcorrente("Lituânia", "Monika Linkyté", "Stay", Enum.Parse<Ronda>("Semifinal2"), 0, 110);
            Eurovisao s2f5 = gestaoEurovisao.NovoConcorrente("Eslovénia", "Joker Out", "Carpe Diem", Enum.Parse<Ronda>("Semifinal2"), 0, 103);
            Eurovisao s2f6 = gestaoEurovisao.NovoConcorrente("Arménia", "Brunette", "Future Lover", Enum.Parse<Ronda>("Semifinal2"), 0, 99);
            Eurovisao s2f7 = gestaoEurovisao.NovoConcorrente("Chipre", "Andrew Lambrou", "Break a Broken Heart", Enum.Parse<Ronda>("Semifinal2"), 0, 94);
            Eurovisao s2f8 = gestaoEurovisao.NovoConcorrente("Bélgica", "Gustaph", "Because of You", Enum.Parse<Ronda>("Semifinal2"), 0, 90);
            Eurovisao s2f9 = gestaoEurovisao.NovoConcorrente("Albânia", "Albina & Familija Kelmendi", "Duje", Enum.Parse<Ronda>("Semifinal2"), 0, 83);
            Eurovisao s2f10 = gestaoEurovisao.NovoConcorrente("Estónia", "Alika", "Bridges", Enum.Parse<Ronda>("Semifinal2"), 0, 74);
            Eurovisao s2f11 = gestaoEurovisao.NovoConcorrente("Islândia", "Diljá", "Power", Enum.Parse<Ronda>("Semifinal2"), 0, 44);
            Eurovisao s2f12 = gestaoEurovisao.NovoConcorrente("Geórgia", "Iru", "Echo", Enum.Parse<Ronda>("Semifinal2"), 0, 33);
            Eurovisao s2f13 = gestaoEurovisao.NovoConcorrente("Grécia", "Victor Vernicos", "What They Say", Enum.Parse<Ronda>("Semifinal2"), 0, 14);
            Eurovisao s2f14 = gestaoEurovisao.NovoConcorrente("Dinamarca", "Reiley", "Breaking My Heart", Enum.Parse<Ronda>("Semifinal2"), 0, 6);
            Eurovisao s2f15 = gestaoEurovisao.NovoConcorrente("Roménia", "Theodor Andrei", "D.G.T. (Off and On)", Enum.Parse<Ronda>("Semifinal2"), 0, 0);
            Eurovisao s2f16 = gestaoEurovisao.NovoConcorrente("San Marino", "Piqued Jacks", "Like An Animal", Enum.Parse<Ronda>("Semifinal2"), 0, 0);

            VerificarAdiciona(gestaoEurovisao, s2f1);
            VerificarAdiciona(gestaoEurovisao, s2f2);
            VerificarAdiciona(gestaoEurovisao, s2f3);
            VerificarAdiciona(gestaoEurovisao, s2f4);
            VerificarAdiciona(gestaoEurovisao, s2f5);
            VerificarAdiciona(gestaoEurovisao, s2f6);
            VerificarAdiciona(gestaoEurovisao, s2f7);
            VerificarAdiciona(gestaoEurovisao, s2f8);
            VerificarAdiciona(gestaoEurovisao, s2f9);
            VerificarAdiciona(gestaoEurovisao, s2f10);
            VerificarAdiciona(gestaoEurovisao, s2f11);
            VerificarAdiciona(gestaoEurovisao, s2f12);
            VerificarAdiciona(gestaoEurovisao, s2f13);
            VerificarAdiciona(gestaoEurovisao, s2f14);
            VerificarAdiciona(gestaoEurovisao, s2f15);
            VerificarAdiciona(gestaoEurovisao, s2f16);


            /*--------------------------Mostra lista de concorrentes da segunda Semifinal:-----------------------------------*/

            Console.WriteLine("\n----------------------Segunda Semifinal da Eurovisão 2023----------------------");
            Console.WriteLine("\nLista dos concorrentes da segunda Semifinal:");
            Console.WriteLine("ID\t|País\t|Representante\t|Música\t|Júri\t|Televoto\t|Total Pontos");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            //MostrarLista(gestaoEurovisao.GetConcorrentesList(Enum.Parse<Ronda>("Semifinal2")));

            /*--------------------------Apagar os 6 concorrentes com menos pontos da lista:--------------------------------------*/

            Console.WriteLine("\nInfelizmente, apenas 10 países da segunda Semifinal passam para a grande Final, por isso, vão ser apagados os 6 concorrentes que obtiveram menos pontos do televoto...");
            Console.WriteLine("\nLista atualizada: ");

            gestaoEurovisao.ApagarConcorrente("Islândia");
            gestaoEurovisao.ApagarConcorrente("Geórgia");
            gestaoEurovisao.ApagarConcorrente("Grécia");
            gestaoEurovisao.ApagarConcorrente("Dinamarca");
            gestaoEurovisao.ApagarConcorrente("Roménia");
            gestaoEurovisao.ApagarConcorrente("San Marino");


            /*-------------------------------Lista dos concorrentes da Final:-------------------------------------------*/

            Console.WriteLine("\n----------------------Final da Eurovisão 2023----------------------");
            Console.WriteLine("\nAos 20 concorrentes que participaram nas Semifinais, juntam-se os 6 países já automaticamente qualificados para a final: Ucrânia (vencedora da última edição), Itália, França, Espanha, Reino Unido e Alemanha....");

            //Adicionar os concorrentes que já estavam automaticamente qualificados para a final:
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("Itália", "Marco Mengoni", "Due Vite", Enum.Parse<Ronda>("Final"), 176, 174));
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("Ucrânia", "Tvorchi", "Heart of Steel", Enum.Parse<Ronda>("Final"), 54, 189));
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("França", "La Zarra", "Évidemment", Enum.Parse<Ronda>("Final"), 54, 50));
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("Espanha", "Blanca Paloma", "Eaea", Enum.Parse<Ronda>("Final"), 95, 5));
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("Reino Unido", "Mae Muller", "I Wrote A Song", Enum.Parse<Ronda>("Final"), 15, 9));
            VerificarAdiciona(gestaoEurovisao, gestaoEurovisao.NovoConcorrente("Alemanha", "Lord Of The Lost", "Blood & Glitter", Enum.Parse<Ronda>("Final"), 3, 15));


            /*--------------------------Alterar Ronda para final:--------------------------------------*/

            Console.WriteLine("\nA alterar as rondas dos países das semifinais qualificados para a final....");


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

            
            /*--------------------------Se quiser alterar Pontos do Júri:--------------------------------------*/
            
            Console.WriteLine($"\nA verificar a existência dos seguintes países qualificados para a final: \n- {s1f1.Pais} \n- {s1f2.Pais} \n- {s1f3.Pais} " +
                $"\n- {s1f4.Pais} \n- {s1f5.Pais} \n- {s1f6.Pais} \n- {s1f7.Pais} \n- {s1f8.Pais} \n- {s1f9.Pais} \n- {s1f10.Pais} \n- {s2f1.Pais} " +
                $"\n- {s2f2.Pais} \n- {s2f3.Pais} \n- {s2f4.Pais} \n- {s2f5.Pais} \n- {s2f6.Pais} \n- {s2f7.Pais} \n- {s2f8.Pais} \n- {s2f9.Pais} " +
                $"\n- {s2f10.Pais} \nSe existirerem, a alterar pontos do Júri de todas as músicas, pois na final há uma nova votação....");
            
            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID) && gestaoEurovisao.ExisteConcorrente(s1f2.ID) && gestaoEurovisao.ExisteConcorrente(s1f3.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f4.ID) && gestaoEurovisao.ExisteConcorrente(s1f5.ID) && gestaoEurovisao.ExisteConcorrente(s1f6.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f7.ID) && gestaoEurovisao.ExisteConcorrente(s1f8.ID) && gestaoEurovisao.ExisteConcorrente(s1f9.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f10.ID) && gestaoEurovisao.ExisteConcorrente(s2f1.ID) && gestaoEurovisao.ExisteConcorrente(s2f2.ID)
                && gestaoEurovisao.ExisteConcorrente(s2f3.ID) && gestaoEurovisao.ExisteConcorrente(s2f4.ID) && gestaoEurovisao.ExisteConcorrente(s2f5.ID) 
                && gestaoEurovisao.ExisteConcorrente(s2f6.ID) && gestaoEurovisao.ExisteConcorrente(s2f7.ID) && gestaoEurovisao.ExisteConcorrente(s2f8.ID) 
                && gestaoEurovisao.ExisteConcorrente(s2f9.ID) && gestaoEurovisao.ExisteConcorrente(s2f10.ID))
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
            
            Console.WriteLine($"\nA verificar a existência dos seguintes países qualificados para a final: \n- {s1f1.Pais} \n- {s1f2.Pais} \n- {s1f3.Pais} " +
                $"\n- {s1f4.Pais} \n- {s1f5.Pais} \n- {s1f6.Pais} \n- {s1f7.Pais} \n- {s1f8.Pais} \n- {s1f9.Pais} \n- {s1f10.Pais} \n- {s2f1.Pais} " +
                $"\n- {s2f2.Pais} \n- {s2f3.Pais} \n- {s2f4.Pais} \n- {s2f5.Pais} \n- {s2f6.Pais} \n- {s2f7.Pais} \n- {s2f8.Pais} \n- {s2f9.Pais} " +
                $"\n- {s2f10.Pais} \nSe existirem, a alterar pontos do Televoto de todas as músicas, pois na final há uma nova votação....");

            if (gestaoEurovisao.ExisteConcorrente(s1f1.ID) && gestaoEurovisao.ExisteConcorrente(s1f2.ID) && gestaoEurovisao.ExisteConcorrente(s1f3.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f4.ID) && gestaoEurovisao.ExisteConcorrente(s1f5.ID) && gestaoEurovisao.ExisteConcorrente(s1f6.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f7.ID) && gestaoEurovisao.ExisteConcorrente(s1f8.ID) && gestaoEurovisao.ExisteConcorrente(s1f9.ID) 
                && gestaoEurovisao.ExisteConcorrente(s1f10.ID) && gestaoEurovisao.ExisteConcorrente(s2f1.ID) && gestaoEurovisao.ExisteConcorrente(s2f2.ID)
                && gestaoEurovisao.ExisteConcorrente(s2f3.ID) && gestaoEurovisao.ExisteConcorrente(s2f4.ID) && gestaoEurovisao.ExisteConcorrente(s2f5.ID) 
                && gestaoEurovisao.ExisteConcorrente(s2f6.ID) && gestaoEurovisao.ExisteConcorrente(s2f7.ID) && gestaoEurovisao.ExisteConcorrente(s2f8.ID) 
                && gestaoEurovisao.ExisteConcorrente(s2f9.ID) && gestaoEurovisao.ExisteConcorrente(s2f10.ID))
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

            //Não está a funcionar:
            //Eurovisao vencedor = gestaoEurovisao.Vencedor(); //vai buscar o pais que tem maior total pontos e portanto será o vencedor da Eurovisão 2023!
            //Console.WriteLine($"\nE o vencedor da Eurovisão 2023 é.... {vencedor.Pais.ToUpper()}!!!"); //ToUpper para colocar o vencedor em letras maiúsculas

            /*
            Console.WriteLine("\nHistórico:\n");
            MostrarHistorico(gestaoEurovisao.Historico()); //-----------------------ainda não está a funcionar direito
            */
        }


        private static void MostrarLista(List<string> lista) //método responsável por mostrar a lista com todos os objetos (concorrentes)
        {
            foreach (var concorrente in lista)
            {
                Console.WriteLine(concorrente.ToString());
            }
        }
        private static void MostrarHistorico(List<string> historico) //método responsável por mostrar o histórico com todos os objetos (concorrentes)
        {
            foreach (string entrada in historico)
            {
                Console.WriteLine(entrada);
            }
        }
        private static void VerificarAdiciona(Eurovisao_BR br, Eurovisao novo)
        {
            if (novo != null)
            {
                Eurovisao? obj = null;
                if (!br.ExisteConcorrente(novo.Pais, out obj))
                {
                    br.AdicionarConcorrente(novo);
                    Console.WriteLine($"Concorrente de '{novo.Pais}' foi adicionado na BD!");
                }
                else
                {
                    Console.WriteLine($"Concorrente de '{novo.Pais}' já existe na BD!");
                }
            }
        }
    }
}