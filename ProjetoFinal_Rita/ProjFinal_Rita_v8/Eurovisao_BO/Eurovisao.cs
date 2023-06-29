using System.Xml.Serialization;
using ToolBox;
using Eurovisao_Constantes;
using System.ComponentModel;
using System.Reflection;

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
        public Ronda Ronda { get; set; }
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
            ID = GetNewId.Instancia.Proximo;
            Pais = pais;
            NomeRepresentante = nomeRepresentante;
            Ronda = ronda;
            NomeMusica = nomeMusica;
            PontosJuri = pontosJuri;
            PontosTelevoto = pontosTelevoto;
        }
        
        public Eurovisao(RegistoConcorrente registo)
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
                PontosTelevoto = this.PontosTelevoto,
            };
        }
        
        public override string ToString()
        {
            return $"{ID}\t|{Pais}\t|{NomeRepresentante}\t|{NomeMusica}\t|{Ronda}\t|{PontosJuri}\t|{PontosTelevoto}\t|{TotalPontos}";
        }
    }
}