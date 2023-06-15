using Anotacoes_Constantes;
namespace Anotacao_BO
{
    public class AnotacoesAula
    {
        //Propriedades
        public string Nome { get; set; }
        public string Aula { get; set; }
        public Tipo Tipo { get; set; }
        public bool Revisado { get; set; }

        //Construtores
        public AnotacoesAula(string nome, string aula, Tipo tipo, bool revisado) 
        {
            Nome = nome;
            Aula = aula;
            Tipo = tipo;
            Revisado = revisado;
        }

        public override string? ToString()
        {
            return $"{Revisado}\t|\t{Nome}\t|\t{Aula}\t|\t{Tipo}\n";
        }
    }
}