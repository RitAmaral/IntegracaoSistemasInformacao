using Eurovisao_BO;

namespace Eurovisao_DAL
{
    public class Eurovisao_DAO
    {
        private List<Eurovisao> _eurovisaoList; //criação da lista

        public Eurovisao_DAO()
        {
            _eurovisaoList = new List<Eurovisao>();
        }
        //Métodos
        public bool AdicionarConcorrente(Eurovisao concorrente) //Adicionar pais concorrente na eurovisão
        {
            if (ReferenceEquals(concorrente, null)) return false;
            _eurovisaoList.Add(concorrente);
            return true;
        }
        public List<string> GetConcorrentesList()
        {
            List<string> list = new List<string>();
            foreach (Eurovisao concorrente in _eurovisaoList)
            {
                list.Add(concorrente.ToString());
            }
            return list;
        }
        public bool ApagarConcorrente(string pais)
        {
            Eurovisao? obj = null;
            string tPais = pais.Trim();
            if (ExisteConcorrente(tPais, out obj))
            {
                if (obj == null) return false;
                return _eurovisaoList.Remove(obj);
            }
            return false;
        }
        public bool ExisteConcorrente(string pais)
        {
            Eurovisao? obj = null;
            return ExisteConcorrente(pais, out obj);
        }
        public bool ExisteConcorrente(string pais, out Eurovisao? obj)
        {
            obj = null;
            string tPais = pais.Trim();
            if (tPais.Length == 0) return false;
            obj = _eurovisaoList.Find(c => c.Pais.CompareTo(tPais) == 0);
            return !ReferenceEquals(obj, null);
        }
    }
}