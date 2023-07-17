using System.Text.Json.Serialization;
using Anotacoes_Constantes;

namespace Anotacoes_Models2Api
{
    public class AnotRegistoRequest
    { //aqui não colocar id, só colocar no response
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
