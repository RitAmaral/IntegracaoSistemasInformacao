using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurovisao_BO
{
    public class RondaEuro
    {
        public string Ronda { get; set; }
        public int PontosJuri { get; set; }
        public int PontosTelevoto { get; set; }
        public int TotalPontos => PontosJuri + PontosTelevoto;

        public RondaEuro(string ronda, int pontosJuri, int pontosTelevoto)
        {
            Ronda = ronda;
            PontosJuri = pontosJuri;
            PontosTelevoto = pontosTelevoto;
        }
    }
}
