using Agenda_Constantes;
using System.Xml.Serialization;
using ToolBox;
namespace Agenda_BO
{
    //nao devemos serializar classes, por isso devemos usar o struct (é uma especie de classe, mas o comportamento é diferente)
    [Serializable]
    public struct RegistoCompromisso
    {
        [XmlElement]
        public int Id { get; set; }
        [XmlElement]
        public DateTime Data { get; set; }
        [XmlElement]
        public int Bloco { get; set; }
        [XmlElement]
        public Prioridade Prioridade { get; set; }
        [XmlElement]
        public string Nome { get; set; }
        [XmlElement]
        public string Assunto { get; set; }
        [XmlElement]
        public TipoAgendamento TipoAgendamento { get; set; }
        [XmlElement]
        public bool Concluido { get; set; }
        [XmlElement]
        public DateTime Conclusao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Id}, {Data}\t{Nome}, {Assunto}";
        }
    }
    public class Compromisso
    {
        //Propriedades
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Bloco { get; set; }
        public Prioridade Prioridade { get; set; } // ir a dependencias (botao lado direito) de Agenda_BO, adicionar ref de projeto Agenda_Constantes
        public string Nome { get; set; }
        public string Assunto { get; set; }
        public TipoAgendamento TipoAgendamento { get; set; }
        public bool Concluido { get; set; }
        public DateTime Conclusao { get; set; }

        //Construtores
        public Compromisso(DateTime data, int bloco, Prioridade prioridade, string nome, string assunto, TipoAgendamento tipoAgendamento)
        {
            Id = GetNewId.Instancia.Proximo; //adicionar dependencia ToolBox, e depois colocar using ToolBox
            Bloco = bloco;
            Data = data;
            Prioridade = prioridade;
            Nome = nome;
            Assunto = assunto;
            TipoAgendamento = tipoAgendamento;
            Concluido = false;
            Conclusao = new DateTime();
        }

        public Compromisso(RegistoCompromisso registo) //construtor
        {
            Id = registo.Id;
            Nome = registo.Nome;
            Assunto = registo.Assunto;
            Bloco = registo.Bloco;
            Prioridade = registo.Prioridade;
            Data = registo.Data;
            TipoAgendamento = registo.TipoAgendamento;
            Concluido = registo.Concluido;
            Conclusao = registo.Conclusao;
        }
        //Métodos
        public RegistoCompromisso RegistoCompromisso() //método
        {
            return new RegistoCompromisso
            {
                Id = this.Id,
                Data = this.Data,
                Nome = this.Nome,
                Assunto = this.Assunto,
                Prioridade = this.Prioridade,
                TipoAgendamento = this.TipoAgendamento,
                Bloco = this.Bloco,
                Conclusao = this.Conclusao,
                Concluido = this.Concluido
            };
        }

        public override string? ToString() // ? -> porque pode ser nulo, pode retornar string ou nada
        { // t = tab (acrescenta 8 espaços)
            return $"{Id}:\t{Data}\t{Nome}, {Assunto}";
        }
    }

}