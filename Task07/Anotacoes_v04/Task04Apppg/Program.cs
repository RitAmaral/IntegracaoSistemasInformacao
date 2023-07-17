using Anotacao_BOpg;
using Anotacao_BLpg;
using Anotacoes_Constantes;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        AnotacoesAula_BR gestaoAnotacoes = new AnotacoesAula_BR();

        /*-------------------------------------Adicionar objetos à lista----------------------------------*/

        AnotacoesAula novo1 = gestaoAnotacoes.NovaAnotacao("O problema da distribuição", "MATEMÁTICA 630", Enum.Parse<Tipo>("Seminario"), false);

        Console.WriteLine("... a verificar os dados na BD ...");
        VerificarAdiciona(gestaoAnotacoes, novo1);

        VerificarAdiciona(gestaoAnotacoes, novo1);
        VerificarAdiciona(gestaoAnotacoes, gestaoAnotacoes.NovaAnotacao("Economia Americana Pós-Guerra", "HISTÓRIA 230", Enum.Parse<Tipo>("Sessao"), true));
        VerificarAdiciona(gestaoAnotacoes, gestaoAnotacoes.NovaAnotacao("Kazuo Ishiguro: Debate", "LITERATURA 455", Enum.Parse <Tipo>("GrupoDeEstudo"), false));
        VerificarAdiciona(gestaoAnotacoes, gestaoAnotacoes.NovaAnotacao("Formas Barrocas: Kandinsky", "ARTE 399", Enum.Parse<Tipo>("Leitura"), true));
        VerificarAdiciona(gestaoAnotacoes, gestaoAnotacoes.NovaAnotacao("Literatura britânica dos anos 90", "LITERATURA 455", Enum.Parse<Tipo>("Aula"), false));
        VerificarAdiciona(gestaoAnotacoes, gestaoAnotacoes.NovaAnotacao("Ciências da Computação 104: Aula 5", "Ciências da Computação 104", Enum.Parse<Tipo>("Aula"), false));


        /*-------------------------------------Listar os objetos----------------------------------*/

        Console.WriteLine("Listar os objetos:");
        Console.WriteLine("REVISADO\t|\tID\t|\tNOME\t|\tAULA\t|\tTIPO");
        Console.WriteLine("-----------------------------------------------------------------------------------------");
        MostrarLista(gestaoAnotacoes.GetAnotacoesList());

        /*-------------------------------------Apagar objeto----------------------------------*/

        Console.WriteLine("A apagar o objeto com o nome \"Formas Barrocas: Kandinsky\"");
        if (gestaoAnotacoes.ApagarAnotacao("Formas Barrocas: Kandinsky"))
            MostrarLista(gestaoAnotacoes.GetAnotacoesList());

        /*-------------------------------------Verificar existência do objeto e modificar o ID----------------------------------*/

        Console.WriteLine();
        Console.WriteLine($"A verificar a existência do objeto com o nome \"{novo1.Nome}\"...");
        if (gestaoAnotacoes.ExisteAnotacao(novo1.Nome))
        {
            Console.WriteLine($"A modificar o ID do objeto com o nome \"{novo1.Nome}\"...");
            novo1.Id = 10; //quero mudar o ID para 10
            gestaoAnotacoes.ModificarAnotacao(1, novo1); //o novo1 tem o ID = 1, e vai passar para ID = 10
        }

        /*-------------------------------------Lista os objetos após apagar e modificar----------------------------------*/

        Console.WriteLine();
        Console.WriteLine("Listar os objetos:");
        MostrarLista(gestaoAnotacoes.GetAnotacoesList());


    }
    private static void MostrarLista(List<string> lista) //método criado para mostrar todos os objetos da lista
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
    private static void VerificarAdiciona(AnotacoesAula_BR br, AnotacoesAula novo)
    {
        if (novo != null)
        {
            AnotacoesAula? obj = null;
            if (!br.ExisteAnotacao(novo.Nome, out obj))
            {
                br.AdicionarAnotacao(novo);
                Console.WriteLine($"Compromisso para {novo.Nome} foi adicionado na BD!");
            }
            else
            {
                Console.WriteLine($"Compromisso para {novo.Nome} já existe na BD!");
            }
        }
    }
}