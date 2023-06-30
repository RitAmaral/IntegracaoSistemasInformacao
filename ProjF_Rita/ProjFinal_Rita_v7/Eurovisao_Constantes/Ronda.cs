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
        SemiFinal1 = 1,
        SemiFinal2 = 2,
        Final = 3
    }
}
