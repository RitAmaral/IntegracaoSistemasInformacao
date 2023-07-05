using Eurovisao_Constantes; //criar dependencia para constantes, e colocar aqui o using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Eurovisao_Models2Api
{
    public class EuroRegistoRequest
    { //é uma replica da estrutura do BO, mas sem ID
        //dizer à plataforma como vamos serializar (em Json):
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
