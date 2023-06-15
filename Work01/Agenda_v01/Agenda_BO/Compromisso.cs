using Agenda_Constantes;
namespace Agenda_BO
{
    public class Compromisso
    {
        //Propriedades
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
            Bloco = bloco;
            Data = data;
            Prioridade = prioridade;
            Nome = nome;
            Assunto = assunto;
            TipoAgendamento = tipoAgendamento;
            Concluido = false;
            Conclusao = new DateTime();
        }
        //Método
        public override string? ToString() // ? -> porque pode ser nulo, pode retornar string ou nada
        { // t = tab (acrescenta 8 espaços)
            return $"{Data}\t{Nome}, {Assunto}";
        }
    }
}