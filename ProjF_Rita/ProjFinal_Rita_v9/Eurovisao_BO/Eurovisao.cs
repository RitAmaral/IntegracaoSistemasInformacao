using System.Xml.Serialization;
using ToolBox;
using Eurovisao_Constantes;
using System.ComponentModel;
using System.Reflection;
using Eurovisao_Models2Api;

namespace Eurovisao_BO
{
    
    [Serializable]
    public struct RegistoConcorrente
    {
        [XmlElement]
        public int ID { get; set; }
        [XmlElement]
        public string Pais { get; set; }
        [XmlElement]
        public string NomeRepresentante { get; set; }
        [XmlElement]
        public string NomeMusica { get; set; }
        [XmlElement]
        public string Ronda { get; set; }
        [XmlElement]
        public int PontosJuri { get; set; }
        [XmlElement]
        public int PontosTelevoto { get; set; }
        [XmlElement]
        public int TotalPontos => PontosJuri + PontosTelevoto;

        public override string? ToString()
        {
            return $"{ID}\t|{Pais}\t|{NomeRepresentante}\t|{NomeMusica}\t|{Ronda}\t|{PontosJuri}\t|{PontosTelevoto}\t|{TotalPontos}";
        }
    }
    
    public class Eurovisao: RondaEuro
    {
        // Propriedades
        public int ID { get; set; }
        public string Pais { get; set; }
        public string NomeRepresentante { get; set; }
        public string NomeMusica { get; set; }



        // Construtores
        public Eurovisao(string pais, string nomeRepresentante, string nomeMusica, string ronda, int pontosJuri, int pontosTelevoto): base(ronda, pontosJuri, pontosTelevoto)
        {
            ID = GetNewId.Instancia.Proximo;
            Pais = pais;
            NomeRepresentante = nomeRepresentante;
            Ronda = ronda;
            NomeMusica = nomeMusica;
            PontosJuri = pontosJuri;
            PontosTelevoto = pontosTelevoto;
        }
        
        public Eurovisao(RegistoConcorrente registo) : base(registo.Ronda, registo.PontosJuri, registo.PontosTelevoto)
        {
            ID = registo.ID;
            Pais = registo.Pais;
            NomeRepresentante = registo.NomeRepresentante;
            NomeMusica = registo.NomeMusica;
            Ronda = registo.Ronda; 
            PontosJuri = registo.PontosJuri;
            PontosTelevoto = registo.PontosTelevoto;
        }
        //Métodos

        public RegistoConcorrente RegistoConcorrentes()
        {
            return new RegistoConcorrente
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