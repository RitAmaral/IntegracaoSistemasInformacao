using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurovisao_Constantes
{
    [Serializable] //se o enum não for serializado vai dar erro.
    public enum Ronda: byte
    {
        Semifinal1 = 1,
        Semifinal2 = 2,
        Final = 3
    }
}
