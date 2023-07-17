using Eurovisao_BLpg; //criar dependencia e colocar using aqui

namespace Eurovisao_Services2Apipg
{
    public class EurovisaoServices
    {
        //aloca memória quando esse objeto for invocado, ate lá só existe a nível de conceito
        private readonly Lazy<Eurovisao_BR> _concorrentes = new Lazy<Eurovisao_BR>(() => new Eurovisao_BR());

        //criar propriedade:
        public Eurovisao_BR Concorrentes => _concorrentes.Value;
    }
}