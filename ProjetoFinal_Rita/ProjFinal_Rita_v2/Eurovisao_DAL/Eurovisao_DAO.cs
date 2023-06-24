using Eurovisao_BO;
using SerializeTools;
using System.Xml.Serialization;
using ToolBox;
using Eurovisao_Constantes;
//using static Eurovisao_BO.RegistoConcorrente;

namespace Eurovisao_DAL
{
    public class Eurovisao_DAO
    {
        /*
        [XmlRoot(ElementName = "Concorrentes")]
        public class EurovisaoBD //criar classe, vai representar a base de dados; é composta por uma lista de concorrentes
        {
            public EurovisaoBD()
            {
                Items = new List<RegistoConcorrente>();
            }

            [XmlElement(ElementName = "Concorrente")]
            public List<RegistoConcorrente> Items { get; set; }
        }
        */
        public class EurovisaoBD //criar classe, vai representar a base de dados; é composta por uma lista de concorrentes
        {
            public EurovisaoBD()
            {
                Items = new List<Eurovisao>();
            }

            public List<Eurovisao> Items { get; set; }
        }


        private EurovisaoBD _eurovisaoList;

        public Eurovisao_DAO()
        {
            _eurovisaoList = new EurovisaoBD();
        }
        //Métodos
        public bool AdicionarConcorrente(Eurovisao concorrente)
        {
            _eurovisaoList.Items.Add(concorrente); //adiciona à lista
            return true;
        }

        public List<string> GetConcorrentesList()
        {
            List<string> list = new List<string>();
            foreach (Eurovisao concorrente in _eurovisaoList.Items)
            {
                list.Add(concorrente.ToString());
            }
            return list;
        }

        public bool ApagarConcorrente(string pais)
        {
            string tPais = pais.Trim();
            Eurovisao concorrente = _eurovisaoList.Items.FirstOrDefault(e => e.Pais.Equals(tPais));

            if (concorrente != null)
            {
                _eurovisaoList.Items.Remove(concorrente);
                return true;
            }

            return false;
        }
        public bool ExisteConcorrente(string pais)
        {
            return _eurovisaoList.Items.Any(e => e.Pais.Equals(pais));
        }
        public bool ExisteConcorrente(int iD)
        {
            return _eurovisaoList.Items.Any(e => e.ID.Equals(iD));
        }

        public bool ModificarPontosJuri(int id, int pontosJuri) // modifica pontos do juri de um concorrente pelo id
        {
            Eurovisao concorrente = _eurovisaoList.Items.FirstOrDefault(c => c.ID == id);
            if (concorrente != null)
            {
                concorrente.PontosJuri = pontosJuri;
                AtualizarClassificacaoFinal();
                return true;
            }
            return false;
        }
        public bool ModificarPontosTelevoto(int id, int pontosTelevoto) //modifica pontos do televoto de um concorrente pelo id
        {
            Eurovisao concorrente = _eurovisaoList.Items.FirstOrDefault(c => c.ID == id);
            if (concorrente != null)
            {
                concorrente.PontosTelevoto = pontosTelevoto;
                AtualizarClassificacaoFinal();
                return true;
            }
            return false;
        }

        private void AtualizarClassificacaoFinal() //atualiza classificação final com base na modificação dos pontos de juri e televoto
        {
            _eurovisaoList.Items = _eurovisaoList.Items.OrderByDescending(c => c.PontosJuri + c.PontosTelevoto).ToList();
            for (int i = 0; i < _eurovisaoList.Items.Count; i++)
            {
                _eurovisaoList.Items[i].ClassificacaoFinal = i + 1;
            }
        }

        /*
        public bool AdicionarConcorrente(Eurovisao concorrente) //Adicionar pais concorrente na eurovisão
        {
            if (ReferenceEquals(concorrente, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            _eurovisaoList.Items.Add(concorrente.RegistoConcorrentes());
            return true;
        }
        public bool AdicionarConcorrente(RegistoConcorrente concorrente)
        { 
            _eurovisaoList.Items.Add(concorrente); //adiciona à lista
            return true;
        }
        public List<string> GetConcorrentesList1()
        {
            List<string> list = new List<string>();
            foreach (RegistoConcorrente concorrente in _eurovisaoList.Items)
            {
                list.Add(concorrente.ToString());
            }
            return list;
        }
        public List<string> GetConcorrentesList()
        {
            List<string> list = new List<string>();
            foreach (RegistoConcorrente concorrente in _eurovisaoList.Items)
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
                if (ReferenceEquals(obj, null)) return false;
                // apagar todos os registos com o nome igual ao "país"
                if (_eurovisaoList.Items.RemoveAll(r => r.Pais.Equals(pais)) > 0) //se for maior que 0, significa que eliminou pelo menos 1 registo.
                {
                    return true;
                }
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
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.Pais.Equals(pais));
            if (tIndex > -1)
            {
                obj = new Eurovisao(_eurovisaoList.Items[tIndex]);
                return true;
            }
            return false;
        }
        
        public void ExportarDados()
        {
            if (!File.Exists(Constantes.NomeXmlEurovisao))
            {
                try
                {
                    ExportarXml(Constantes.NomeXmlEurovisao);
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
                    XmlMethods.SerializeToXml<EurovisaoBD>(_eurovisaoList, ficheiro);

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
            return ImportarXml(Constantes.NomeXmlEurovisao);
        }
        public bool ImportarXml(string ficheiro)
        {
            if (ficheiro != null && File.Exists(ficheiro))
            {
                try
                {
                    _eurovisaoList = XmlMethods.DeserializeXmlToObject<EurovisaoBD>(ficheiro);
                    // uma proposta de solução para evitar duplicação de Id's
                    // estratégia para se atualizar o gerador de Id's
                    if (_eurovisaoList.Items.Count > 0)
                    {
                        int tID = _eurovisaoList.Items[0].ID;
                        foreach (RegistoConcorrente r in _eurovisaoList.Items)
                        {
                            if (r.ID > tID) tID = r.ID;
                        }
                        GetNewId.Instancia.ResetProximo(tID);
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
        */
    }
}