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

        public AnotacoesAula NovaAnotacao(string nome, string aula, Tipo tipo, bool revisado) //adicionar anotação ao colocar todos os parametros
        {
            string tNome = nome.Trim();
            if (tNome.Length == 0) throw new ArgumentNullException(nameof(tNome));
            string tAula = aula.Trim();
            if (tAula.Length == 0) throw new ArgumentNullException(nameof(tAula));
            Tipo tTipo = tipo;
            bool tRevisado = revisado;

            return new AnotacoesAula(tNome, tAula, tTipo, tRevisado);
        }

        public bool AdicionarAnotacao(AnotacoesAula anotacao) //adicionar anotacao
        {
            if (ReferenceEquals(anotacao, null)) return false;
            return _AnotacoesDao.AdicionarAnotacao(anotacao);
        }
        public List<string> GetAnotacoesList() //mostra lista
        {
            return _AnotacoesDao.GetAnotacoesList();
        }
        public bool ApagarAnotacao(string nome) //apaga anotação pelo nome
        {
            return _AnotacoesDao.ApagarAnotacao(nome);
        }
        public bool ModificarAnotacao(int id, AnotacoesAula anotacao) //modifica id de uma anotação
        {
            if (ReferenceEquals(anotacao, null)) return false;
            return _AnotacoesDao.ModificarAnotacao(id, anotacao);
        }
        public bool ExisteAnotacao(string nome) //verifica se existe anotação pelo nome
        {
            return _AnotacoesDao.ExisteAnotacao(nome);
        }
        public void ExportarDados() //exporta os dados
        {
            _AnotacoesDao.ExportarDados();
        }
        public bool ImportarDados() //importa os dados
        {
            return _AnotacoesDao.ImportarDados();
        }
    }
}