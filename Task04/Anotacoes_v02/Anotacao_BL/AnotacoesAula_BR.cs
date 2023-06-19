using Anotacao_BO;
using Anotacao_DAL;
using Anotacoes_Constantes;

namespace Anotacao_BL
{
    public class AnotacoesAula_BR
    {
        private AnotacoesAula_DAO _AnotacoesDao;

        public AnotacoesAula_BR()
        {
            _AnotacoesDao = new AnotacoesAula_DAO();
        }

        public AnotacoesAula NovaAnotacao(string nome, string aula, Tipo tipo, bool revisado)
        {
            string tNome = nome.Trim();
            if (tNome.Length == 0) throw new ArgumentNullException(nameof(tNome));
            string tAula = aula.Trim();
            if (tAula.Length == 0) throw new ArgumentNullException(nameof(tAula));
            Tipo tTipo = tipo;
            bool tRevisado = revisado;

            return new AnotacoesAula(tNome, tAula, tTipo, tRevisado);
        }

        public bool AdicionarAnotacao(AnotacoesAula anotacao)
        {
            if (ReferenceEquals(anotacao, null)) return false;
            return _AnotacoesDao.AdicionarAnotacao(anotacao);
        }
        public List<string> GetAnotacoesList()
        {
            return _AnotacoesDao.GetAnotacoesList();
        }
        public bool ApagarAnotacao(string nome)
        {
            return _AnotacoesDao.ApagarAnotacao(nome);
        }
        public bool ExisteAnotacao(string nome)
        {
            return _AnotacoesDao.ExisteAnotacao(nome);
        }
        public void ExportarDados()
        {
            _AnotacoesDao.ExportarDados();
        }
        public bool ImportarDados()
        {
            return _AnotacoesDao.ImportarDados();
        }
    }
}