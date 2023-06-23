using Agenda_BO; //acrescentar aqui e nas dependências
using Agenda_Constantes;
using System.Xml.Serialization;
using static Agenda_BO.RegistoCompromisso;
using SerializeTools;
using ToolBox;

namespace Agenda_DAL
{
    public class Compromisso_DAO //Data Access Layer e Data Access Object
          //Camada de acesso aos dados 
          //a camada de acesso aos dados é que deve aceder à base de dados, e não a camada de lógica
    {
        [XmlRoot(ElementName = "Compromissos")]
        public class CompromissosBD //criar classe, vai representar a base de dados; é composta por uma lista de compromissos
        {
            public CompromissosBD()
            {
                Items = new List<RegistoCompromisso>();
            }

            [XmlElement(ElementName = "Compromisso")]
            public List<RegistoCompromisso> Items { get; set; }
        }

        private CompromissosBD _compromissoList; //criação da lista
        private DateTime _loaded; //variaveis adicionadas (_loaded e _modified) para o momento em que carreguei, e quando foi modificada
        private DateTime _modified;

        public Compromisso_DAO()
        {
            _compromissoList = new CompromissosBD();
        }

        public bool AdicionarCompromisso(Compromisso compromisso)
        {
            if (ReferenceEquals(compromisso, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            return AdicionarCompromisso(compromisso.RegistoCompromisso());
        }
        public bool AdicionarCompromisso(RegistoCompromisso compromisso)
        { // um struct está sempre preenchido
            _compromissoList.Items.Add(compromisso); //adiciona à lista
            _modified = DateTime.Now;
            return true;
        }
        public bool ModificarCompromisso(int id, Compromisso compromisso)
        {
            if (ReferenceEquals(compromisso, null)) return false;
            int tIndex = _compromissoList.Items.FindIndex(r => r.Id.Equals(id));
            if (tIndex > -1)
            {
                _compromissoList.Items[tIndex] = compromisso.RegistoCompromisso();
                _modified = DateTime.Now;
                return true;
            }
            return false;
        }
        public bool ApagarCompromisso(string nome) //apagar pelo nome
        {
            Compromisso? obj = null;
            string tNome = nome.Trim();
            if (ExisteCliente(tNome, out obj))
            {
                if (ReferenceEquals(obj, null)) return false;
                // apagar todos os registos com o nome igual ao "nome"
                if (_compromissoList.Items.RemoveAll(r => r.Nome.Equals(nome)) > 0) //se for maior que 0, significa que eliminou pelo menos 1 registo.
                {
                    _modified = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
        public bool ApagarCompromisso(int id) //apagar pelo id
        {
            int tIndex = _compromissoList.Items.FindIndex(r => r.Id.Equals(id)); //vai buscar a posição do array, se found começa em 0.
            if (tIndex > -1) //se não encontrar devolve -1
            {
                _compromissoList.Items.RemoveAt(tIndex);
                _modified = DateTime.Now;
                return true;
            }
            return false;
        }
        public bool ExisteCliente(string nome) //verificar se existe cliente (pelo nome)
        {
            Compromisso? obj = null;
            return ExisteCliente(nome, out obj);
        }
        public bool ExisteCliente(string nome, out Compromisso? obj)
        {
            obj = null;
            string tNome = nome.Trim();
            if (tNome.Length == 0) return false;
            int tIndex = _compromissoList.Items.FindIndex(r => r.Nome.Equals(nome));
            if (tIndex > -1)
            {
                obj = new Compromisso(_compromissoList.Items[tIndex]);
                return true;
            }
            return false;
        }
        public bool ExisteCliente(int id, out Compromisso? obj)
        {
            obj = null;
            int tIndex = _compromissoList.Items.FindIndex(r => r.Id.Equals(id));
            if (tIndex > -1)
            {
                obj = new Compromisso(_compromissoList.Items[tIndex]);
                return true;
            }
            return false;
        }
        public List<string> GetCompromissoList()
        {
            List<string> list = new List<string>();
            foreach (RegistoCompromisso c in _compromissoList.Items)
            {
                list.Add(c.ToString());
            }
            return list;
        }
        public void ExportarDados() //exporta a estrutura para xml
        {
            if (_modified > _loaded || !File.Exists(Constantes.NomeXmlCompromissos))
            {
                try
                {
                    ExportarXml(Constantes.NomeXmlCompromissos);
                    _modified = _loaded = DateTime.Now;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public bool ExportarXml(string ficheiro)
        {
            if (ficheiro != null)
            {
                try
                {
                    XmlMethods.SerializeToXml<CompromissosBD>(_compromissoList, ficheiro);

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }
        public bool ImportarDados()
        {
            return ImportarXml(Constantes.NomeXmlCompromissos);
        }
        public bool ImportarXml(string ficheiro)
        {
            if (ficheiro != null && File.Exists(ficheiro))
            {
                try
                {
                    _compromissoList = XmlMethods.DeserializeXmlToObject<CompromissosBD>(ficheiro);
                    _loaded = DateTime.Now;
                    _modified = DateTime.Now;
                    // uma proposta de solução para evitar duplicação de Id's
                    // estratégia para se atualizar o gerador de Id's
                    if (_compromissoList.Items.Count > 0)
                    {
                        int tId = _compromissoList.Items[0].Id;
                        foreach (RegistoCompromisso r in _compromissoList.Items)
                        {
                            if (r.Id > tId) tId = r.Id;
                        }
                        GetNewId.Instancia.ResetProximo(tId);
                    }
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }
    }
}