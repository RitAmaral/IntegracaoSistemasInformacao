using Anotacoes_Constantes;
using System.Xml.Serialization;
using ToolBox;
namespace Anotacao_BO
{
    [Serializable]
    public struct RegistoAnotacao
    {
        [XmlElement]
        public int Id { get; set; }
        [XmlElement]
        public string Nome { get; set; }
        [XmlElement]
        public string Aula { get; set; }
        [XmlElement]
        public Tipo Tipo { get; set; }
        [XmlElement]
        public bool Revisado { get; set; }
        public override string? ToString()
        {
            return $"{Revisado}\t|\t{Id}\t|\t{Nome}\t|\t{Aula}\t|\t{Tipo}\n";
        }
    }
    public class AnotacoesAula
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Aula { get; set; }
        public Tipo Tipo { get; set; }
        public bool Revisado { get; set; }

        //Construtores
        public AnotacoesAula(string nome, string aula, Tipo tipo, bool revisado) 
        {
            Id = GetNewId.Instancia.Proximo; //adicionar dependencia toolbox e colocar using toolbox em cima.
            Nome = nome;
            Aula = aula;
            Tipo = tipo;
            Revisado = revisado;
        }
        public AnotacoesAula(RegistoAnotacao registo) //construtor
        {
            Id = registo.Id;
            Nome = registo.Nome;
            Aula = registo.Aula;
            Tipo = registo.Tipo;
            Revisado= registo.Revisado;
        }
        //Métodos
        public RegistoAnotacao RegistoAnotacao() //metodo
        {
            return new RegistoAnotacao
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