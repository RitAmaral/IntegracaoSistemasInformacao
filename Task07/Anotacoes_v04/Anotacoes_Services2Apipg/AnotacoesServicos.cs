using Anotacao_BLpg;

namespace Anotacoes_Services2Apipg
{
    public class AnotacoesServicos
    {
        private readonly Lazy<AnotacoesAula_BR> _anotacoes = new Lazy<AnotacoesAula_BR>(() => new AnotacoesAula_BR());

        //criar atributo
        public AnotacoesAula_BR Anotacoes => _anotacoes.Value;
    }
}