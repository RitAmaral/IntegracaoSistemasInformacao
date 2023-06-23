using Anotacao_BO;
using Anotacao_BL;
using Anotacoes_Constantes;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        AnotacoesAula_BR gestaoAnotacoes = new AnotacoesAula_BR();
        Console.WriteLine("REVISADO\t|\tID\t|\tNOME\t|\tAULA\t|\tTIPO");
        Console.WriteLine();

        if (!gestaoAnotacoes.ImportarDados())
        {
            Console.WriteLine("Os dados não foram carregados.");
            Console.WriteLine("Adicionar os dois objetos");
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("O problema da distribuição", "MATEMÁTICA 630", Enum.Parse<Tipo>("Seminario"), false));
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("Economia Americana Pós-Guerra", "HISTÓRIA 230", Enum.Parse<Tipo>("Sessao"), true));
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("Kazuo Ishiguro: Debate", "LITERATURA 455", Enum.Parse <Tipo>("GrupoDeEstudo"), false));
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("Formas Barrocas: Kandinsky", "ARTE 399", Enum.Parse<Tipo>("Leitura"), true));
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("Literatura britânica dos anos 90", "LITERATURA 455", Enum.Parse<Tipo>("Aula"), false));
            gestaoAnotacoes.AdicionarAnotacao(gestaoAnotacoes.NovaAnotacao("Ciências da Computação 104: Aula 5", "Ciências da Computação 104", Enum.Parse<Tipo>("Aula"), false));
        }
        else
        {
            Console.WriteLine("Dados carregados!");
        }

        Console.WriteLine("Listar os objetos");
        MostrarLista(gestaoAnotacoes.GetAnotacoesList());

        Console.WriteLine("Apagar o objeto com o nome \"Formas Barrocas: Kandinsky\"");
        if (gestaoAnotacoes.ApagarAnotacao("Formas Barrocas: Kandinsky"))
            MostrarLista(gestaoAnotacoes.GetAnotacoesList());

        Console.WriteLine("Listar os objetos");
        MostrarLista(gestaoAnotacoes.GetAnotacoesList());

        Console.WriteLine("Serializar a lista");
        gestaoAnotacoes.ExportarDados();

    }
    private static void MostrarLista(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}