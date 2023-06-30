using Agenda_Consts; //criar dependencia para constantes, e colocar aqui o using
using System.Text.Json.Serialization;

namespace Agenda_Models2Api
{
    public class AgendaRegistoRequest
    { //é uma replica da estrutura do BO, registo compromisso, retirar ID do request
        //dizer à plataforma como vamos serializar (em Json):
        [property: JsonPropertyName("data")] //escrever isto e depois carregar em cima do erro, e importar a using System.Text.Json.Serialization;
        public DateTime Data { get; set; }
        [property: JsonPropertyName("bloco")]
        public int Bloco { get; set; }
        [property: JsonPropertyName("prioridade")]
        public Prioridade Prioridade { get; set; }
        [property: JsonPropertyName("nome")]
        public string Nome { get; set; }
        [property: JsonPropertyName("assunto")]
        public string Assunto { get; set; }
        [property: JsonPropertyName("tipoagendamento")]
        public TipoAgendamento TipoAgendamento { get; set; }
        [property: JsonPropertyName("concluido")]
        public bool Concluido { get; set; }
        [property: JsonPropertyName("conclusao")]
        public DateTime Conclusao { get; set; }
    }
}