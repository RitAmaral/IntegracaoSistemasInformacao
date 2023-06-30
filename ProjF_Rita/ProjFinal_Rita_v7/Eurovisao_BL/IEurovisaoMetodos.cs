using Eurovisao_BO;
using Eurovisao_Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurovisao_BL
{
    public interface IEurovisaoMetodos //define os métodos que devem ser implementados pelas classes que a utilizam, neste caso Eurovisao_BR
    {
        bool AdicionarConcorrente(Eurovisao concorrente);
        List<string> GetConcorrentesList();
        bool ApagarConcorrente(string pais);
        bool ApagarConcClassificacaoFinal();
        bool ExisteConcorrente(string pais);
        bool ExisteConcorrente(int id);
        bool ModificarPontosJuri(int pontosJuri, Eurovisao concorrente);
        bool ModificarPontosTelevoto(int pontosTelevoto, Eurovisao concorrente);
        bool ModificarRondaConcorrente(string pais, Ronda ronda, Eurovisao concorrente);

    }
}
