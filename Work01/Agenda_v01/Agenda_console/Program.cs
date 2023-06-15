using Agenda_BL;
using Agenda_BO;

internal class Program
{
    private static void Main(string[] args)
    {
        Compromisso_BR gestaoCompromissos = new Compromisso_BR();

        //Compromisso novo = gestaoCompromissos.NovoCompromisso(15, 2, "João Carlos", "Intervalo"); //às 15horas, no bloco 2, logo 15:15:00

        //Console.WriteLine(novo.ToString()); //Output: 14/06/2023 15:15:00     João Carlos, Intervalo
        //Console.WriteLine(novo); //output é igual ao de cima: 14/06/2023 15:15:00     João Carlos, Intervalo

        Compromisso novo1 = gestaoCompromissos.NovoCompromisso(15, 2, "João Carlos", "Intervalo");
        Compromisso novo2 = gestaoCompromissos.NovoCompromisso(16, 4, "João Carlos", "Intervalo");

        gestaoCompromissos.AdicionarCompromisso(novo1);
        gestaoCompromissos.AdicionarCompromisso(novo2);

        foreach (var item in gestaoCompromissos.GetCompromissoList())
        {
            Console.WriteLine(item.ToString());
        }
    }
}