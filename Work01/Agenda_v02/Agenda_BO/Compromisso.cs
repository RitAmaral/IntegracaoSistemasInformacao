using Agenda_Constantes;
using System.Xml.Serialization;
using ToolBox;

namespace Agenda_BO
{
    [Serializable]
    public struct RegistoCompromisso
    {
        [XmlAnyElement]
        public int Id { get; set; }
        [XmlAnyElement]
        public DateTime Data { get; set; }
        [XmlAnyElement]
        public int Bloco { get; set; }
        [XmlAnyElement]
        public Prioridade Prioridade { get; set; } // ir a dependencias (botao lado direito) de Agenda_BO, adicionar ref de projeto Agenda_Constantes
        [XmlAnyElement]
        public string Nome { get; set; }
        [XmlAnyElement]
        public string Assunto { get; set; }
        [XmlAnyElement]
        public TipoAgendamento TipoAgendamento { get; set; }
        [XmlAnyElement]
        public bool Concluido { get; set; }
        [XmlAnyElement]
        public DateTime Conclusao { get; set; }
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
        { //não preciso de colocar aqui em cima o id, concluido e conclusao)
            Id = GetNewId.Instancia.Proximo; //id é automatico
            Bloco = bloco;
            Data = data;
            Prioridade = prioridade;
            Nome = nome;
            Assunto = assunto;
            TipoAgendamento = tipoAgendamento;
            Concluido = false;
            Conclusao = new DateTime();
        }
        //Métodos
        public RegistoCompromisso RegistoCompromisso()
        {
            RegistoCompromisso registo;
            registo.Id = Id;
            registo.Data = Data;
            registo.Nome = Nome;
            registo.Assunto = Assunto;
            registo.Prioridade = Prioridade;
            registo.TipoAgendamento = TipoAgendamento;
            registo.Bloco = Bloco;
            registo.Conclusao = Conclusao;
            registo.Concluido = Concluido;
            return registo;
        }
        public override string? ToString() // ? -> porque pode ser nulo, pode retornar string ou nada
        { // t = tab (acrescenta 8 espaços)
            return $"{Id}: {Data}\t{Nome}, {Assunto}";
        }
    }
}