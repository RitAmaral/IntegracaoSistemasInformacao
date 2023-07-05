using Eurovisao_Constantes; //colocar aqui o using
using System.Text.Json.Serialization;

namespace Eurovisao_Models2Api
{
    public class EuroRegistoResponse
    { //é uma replica da estrutura do BO
        //dizer à plataforma como vamos serializar (em Json):
        [property: JsonPropertyName("id")]
        public int ID { get; set; }
        [property: JsonPropertyName("pais")]
        public string Pais { get; set; }
        [property: JsonPropertyName("nomerepresentante")]
        public string NomeRepresentante { get; set; }
        [property: JsonPropertyName("nomemusica")]
        public string NomeMusica { get; set; }
        [property: JsonPropertyName("ronda")]
        public string Ronda { get; set; }
        [property: JsonPropertyName("pontosjuri")]
        public int PontosJuri { get; set; }
        [property: JsonPropertyName("pontostelevoto")]
        public int PontosTelevoto { get; set; }
        [property: JsonPropertyName("totalpontos")]
        public int TotalPontos => PontosJuri + PontosTelevoto;
    }
}