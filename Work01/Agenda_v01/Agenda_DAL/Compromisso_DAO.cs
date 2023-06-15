using Agenda_BO; //acrescentar aqui e nas dependências

namespace Agenda_DAL
{
    public class Compromisso_DAO //Data Access Layer e Data Access Object
          //Camada de acesso aos dados 
          //a camada de acesso aos dados é que deve aceder à base de dados, e não a camada de lógica
    {
        private List<Compromisso> _compromissoList; //criação da lista
        public Compromisso_DAO()
        {
            _compromissoList = new List<Compromisso>();
        }
        public bool AdicionarCompromisso(Compromisso compromisso)
        {
            if (ReferenceEquals(compromisso, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            _compromissoList.Add(compromisso); //adiciona à lista
            return true;
        }
        public List<string> GetCompromissoList()
        {
            List<string> list = new List<string>();
            foreach (Compromisso c in _compromissoList) //mostra lista 
            {
                list.Add(c.ToString());
            }
            return list;
        }
    }
}