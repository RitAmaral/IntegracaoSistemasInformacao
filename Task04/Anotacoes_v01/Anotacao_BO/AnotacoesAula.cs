using Anotacoes_Constantes;
namespace Anotacao_BO
{
    public class AnotacoesAula
    {
        //Propriedades
        public string Nome { get; set; }
        public string Aula { get; set; }
        public Tipo Tipo { get; set; }

        //Construtores
        public AnotacoesAula(string nome, string aula, Tipo tipo) 
        {
            Nome = nome;
            Aula = aula;
            Tipo = tipo;
        }

        public override string? ToString()
        {
            return $"{Nome}\t|\t{Aula}\t|\t{Tipo}\n";
        }
    }
}