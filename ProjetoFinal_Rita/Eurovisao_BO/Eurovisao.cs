using ToolBox;

namespace Eurovisao_BO
{
    public class Eurovisao
    {
        //Propriedades
        public int ID { get; set; }
        public string Pais { get; set; }
        public string NomeRepresentante { get; set; }
        public string NomeMusica { get; set; }
        public int PontosJuri { get; set; }
        public int PontosTelevoto { get; set; }
        public int ClassificacaoFinal { get; set; }

        //Construtores
        public Eurovisao(string pais, string nomeRepresentante, string nomeMusica, int pontosJuri, int pontosTelevoto, int classificacaoFinal)
        {
            ID = GetNewId.Instancia.Proximo;
            Pais = pais;
            NomeRepresentante = nomeRepresentante;
            NomeMusica = nomeMusica;
            PontosJuri = pontosJuri;
            PontosTelevoto = pontosTelevoto;
            ClassificacaoFinal = classificacaoFinal;
        }
        //Métodos
        public int TotalPontos()
        {
            return PontosJuri + PontosTelevoto;
        }

        public override string? ToString()
        {
            return $"{ID}\t|{Pais}\t|{NomeRepresentante}\t|{NomeMusica}\t|{PontosJuri}\t|{PontosTelevoto}\t|{TotalPontos()}\t|{ClassificacaoFinal}";
        }
    }
}