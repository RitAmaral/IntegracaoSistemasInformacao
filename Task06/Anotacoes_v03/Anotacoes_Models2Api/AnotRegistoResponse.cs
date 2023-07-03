using Anotacoes_Constantes;
using System.Text.Json.Serialization;

namespace Anotacoes_Models2Api
{
    public class AnotRegistoResponse
    {
        [property: JsonPropertyName("id")]
        public int Id { get; set; }
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