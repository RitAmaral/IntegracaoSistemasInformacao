using Anotacao_BO;
using Anotacao_BL;
using Anotacoes_Constantes;

internal class Program
{
    private static void Main(string[] args)
    {
        AnotacoesAula_BR gestaoAnotacoes = new AnotacoesAula_BR();
        Console.WriteLine("NOME\t|\tAULA\t|\tTIPO");
        Console.WriteLine();
        AnotacoesAula novo1 = gestaoAnotacoes.NovaAnotacao("O problema da distribuição", "MATEMÁTICA 630", Enum.Parse<Tipo>("Seminario"));
        AnotacoesAula novo2 = gestaoAnotacoes.NovaAnotacao("Economia Americana Pós-Guerra", "HISTÓRIA 230", Enum.Parse <Tipo>("Sessao"));
        AnotacoesAula novo3 = gestaoAnotacoes.NovaAnotacao("Kazuo Ishiguro: Debate", "LITERATURA 455", Enum.Parse <Tipo>("GrupoDeEstudo"));
        AnotacoesAula novo4 = gestaoAnotacoes.NovaAnotacao("Formas Barrocas: Kandinsky", "ARTE 399", Enum.Parse<Tipo>("Leitura"));
        AnotacoesAula novo5 = gestaoAnotacoes.NovaAnotacao("Literatura britânica dos anos 90", "LITERATURA 455", Enum.Parse<Tipo>("Aula"));
        AnotacoesAula novo6 = gestaoAnotacoes.NovaAnotacao("Ciências da Computação 104: Aula 5", "Ciências da Computação 104", Enum.Parse<Tipo>("Aula"));

        gestaoAnotacoes.AdicionarAnotacao(novo1);
        gestaoAnotacoes.AdicionarAnotacao(novo2);
        gestaoAnotacoes.AdicionarAnotacao(novo3);
        gestaoAnotacoes.AdicionarAnotacao(novo4);
        gestaoAnotacoes.AdicionarAnotacao(novo5);
        gestaoAnotacoes.AdicionarAnotacao(novo6);

        MostrarLista(gestaoAnotacoes.GetAnotacoesList());
        if (gestaoAnotacoes.ApagarAnotacao("Formas Barrocas: Kandinsky"))
            MostrarLista(gestaoAnotacoes.GetAnotacoesList());
    }
    private static void MostrarLista(List<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}