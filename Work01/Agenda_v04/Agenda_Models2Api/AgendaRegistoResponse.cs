using Agenda_Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Agenda_Models2Api
{
    public class AgendaRegistoResponse //mudar de internal para public
    {
        [property: JsonPropertyName("id")]
        public int Id { get; set; }
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
