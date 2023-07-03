using Anotacao_BO;
using Anotacao_BL;
using Anotacoes_Constantes;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        AnotacoesAula_BR gestaoAnotacoes = new AnotacoesAula_BR();

        /*-------------------------------------Adicionar objetos à lista----------------------------------*/

        AnotacoesAula novo1 = gestaoAnotacoes.NovaAnotacao("O problema da distribuição", "MATEMÁTICA 630", Enum.Parse<Tipo>("Seminario"), false);

        if (!gestaoAnotacoes.ImportarDados())
        {
            Console.WriteLine("Os dados não foram carregados.");
            Console.WriteLine("A adicionar os objetos....");
            gestaoAnotacoes.AdicionarAnotacao(novo1);
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

        /*-------------------------------------Serializar a lista----------------------------------*/

        Console.WriteLine("A serializar a lista.....");
        gestaoAnotacoes.ExportarDados(); //ver o ficheiro xml criado em Task04App -> bin -> Debug -> net6.0 -> ListaAnotacoes.xml

    }
    private static void MostrarLista(List<string> lista) //método criado para mostrar todos os objetos da lista
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}