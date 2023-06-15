using Anotacao_BO;

namespace Anotacao_DAL
{
    public class AnotacoesAula_DAO
    {
        //Criação da lista
        private List<AnotacoesAula> _anotacoesList;

        public AnotacoesAula_DAO()
        {
            _anotacoesList = new List<AnotacoesAula>();
        }

        //Métodos
        public bool AdicionarAnotacao(AnotacoesAula anotacao) //Adicionar anotação
        {
            if (ReferenceEquals(anotacao, null)) return false;
            _anotacoesList.Add(anotacao);
            return true;
        }
        public List<string> GetAnotacoesList() 
        {
            List<string> list = new List<string>();
            foreach (AnotacoesAula c in _anotacoesList)
            {
                list.Add(c.ToString());
            }
            return list;
        }
        public bool ApagarAnotacao(string nome)
        {
            AnotacoesAula? obj = null;
            string tNome = nome.Trim();
            if (ExisteAnotacao(tNome, out obj))
            {
                if (obj == null) return false;
                return _anotacoesList.Remove(obj);
            }
            return false;
        }
        public bool ExisteAnotacao(string nome)
        {
            AnotacoesAula? obj = null;
            return ExisteAnotacao(nome, out obj);
        }
        public bool ExisteAnotacao(string nome, out AnotacoesAula? obj)
        {
            obj = null;
            string tNome = nome.Trim();
            if (tNome.Length == 0) return false;
            obj = _anotacoesList.Find(c => c.Nome.CompareTo(tNome) == 0);
            return !ReferenceEquals(obj, null);
        }

    }
}