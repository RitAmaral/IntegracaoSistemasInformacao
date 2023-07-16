using Eurovisao_Constantes;
using System.ComponentModel;
using System.Reflection;
using Eurovisao_Models2Api;

namespace Eurovisao_BOpg
{
    
    
    public class Eurovisao
    {
        // Propriedades
        public int ID { get; set; }
        public string Pais { get; set; }
        public string NomeRepresentante { get; set; }
        public string NomeMusica { get; set; }
        public Ronda Ronda { get; set; }
        public int PontosJuri { get; set; }
        public int PontosTelevoto { get; set; }
        public int TotalPontos => PontosJuri + PontosTelevoto; // Propriedade - Read-only: só leitura, que get/recebe PontosJuri + PontosTelevoto


        // Construtores
        public Eurovisao(string pais, string nomeRepresentante, string nomeMusica, Ronda ronda, int pontosJuri, int pontosTelevoto)
        {
            Pais = pais;
            NomeRepresentante = nomeRepresentante;
            Ronda = ronda;
            NomeMusica = nomeMusica;
            PontosJuri = pontosJuri;
            PontosTelevoto = pontosTelevoto;
        }
        public Eurovisao(int id, string pais, string nomeRepresentante, string nomeMusica, Ronda ronda, int pontosJuri, int pontosTelevoto) : this(
            pais, nomeRepresentante, nomeMusica, ronda, pontosJuri, pontosTelevoto)
        {
            ID = id;
        }

        //Métodos


        public EuroRegistoResponse RegistoConcorrenteResponse() //adicionar dependencia do Eurovisao Models e adicionar o using lá em cima
        {
            return new EuroRegistoResponse
            {
                ID = this.ID,
                Pais = this.Pais,
                NomeRepresentante = this.NomeRepresentante,
                NomeMusica = this.NomeMusica,
                Ronda = this.Ronda,
                PontosJuri = this.PontosJuri,
                PontosTelevoto = this.PontosTelevoto
            };
        }

        public override string ToString()
        {
            return $"{ID}\t|{Pais}\t|{NomeRepresentante}\t|{NomeMusica}\t|{Ronda}\t|{PontosJuri}\t|{PontosTelevoto}\t|{TotalPontos}";
        }
    }
}