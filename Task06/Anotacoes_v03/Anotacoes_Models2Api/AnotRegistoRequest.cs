using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Anotacoes_Constantes;

namespace Anotacoes_Models2Api
{
    public class AnotRegistoRequest
    {
        [property: JsonPropertyName("nome")]
        public string Nome { get; set; }
        [property: JsonPropertyName("aula")]
        public string Aula { get; set; }
        [property: JsonPropertyName("tipo")]
        public Tipo Tipo { get; set; }
        [property: JsonPropertyName("revisado")]
        public bool Revisado { get; set; }
    }
}
