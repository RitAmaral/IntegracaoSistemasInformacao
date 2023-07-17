using Anotacoes_Constantes;
using System.Xml.Serialization;
using Anotacoes_Models2Api;

namespace Anotacao_BOpg
{

    public class AnotacoesAula
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Aula { get; set; }
        public Tipo Tipo { get; set; }
        public bool Revisado { get; set; }

        //Construtores
        public AnotacoesAula(int id, string nome, string aula, Tipo tipo, bool revisado) 
        {
            Id = id; 
            Nome = nome;
            Aula = aula;
            Tipo = tipo;
            Revisado = revisado;
        }
        public AnotacoesAula(string nome, string aula, Tipo tipo, bool revisado)
        {
            Nome = nome;
            Aula = aula;
            Tipo = tipo;
            Revisado = revisado;
        }

        public AnotRegistoResponse RegistoAnotacaoResponse() 
        {
            return new AnotRegistoResponse
            {
                Id = this.Id,
                Nome = this.Nome,
                Aula = this.Aula,
                Tipo = this.Tipo,
                Revisado = this.Revisado
            };
        }

        public override string? ToString()
        {
            return $"{Revisado}\t|\t{Id}\t|\t{Nome}\t|\t{Aula}\t|\t{Tipo}\n";
        }
    }
}