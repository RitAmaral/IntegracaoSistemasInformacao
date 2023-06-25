using Eurovisao_BO;
using SerializeTools;
using System.Xml.Serialization;
using ToolBox;
using Eurovisao_Constantes;
using static Eurovisao_DAL.Eurovisao_DAO;
using System.Reflection;
//using static Eurovisao_BO.RegistoConcorrente;

namespace Eurovisao_DAL
{
    public class Eurovisao_DAO
    {
        
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

        private EurovisaoBD _eurovisaoList;

        public Eurovisao_DAO()
        {
            _eurovisaoList = new EurovisaoBD();
        }
        //Métodos
        public bool AdicionarConcorrente(Eurovisao concorrente) //Adicionar concorrente na eurovisão
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

        public List<string> GetConcorrentesList() //mostra lista de concorrentes
        {
            List<string> list = new List<string>();
            foreach (RegistoConcorrente concorrente in _eurovisaoList.Items)
            {
                list.Add(concorrente.ToString());
            }
            return list;
        }
        public bool ApagarConcorrente(string pais) //apaga concorrente pelo nome do país que representa
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
        public bool ApagarConcClassificacaoFinal() //apagar concorrentes com menores pontuações
        {
            int inicial = _eurovisaoList.Items.Count;
            //ordena a lista por ordem descendente de TotalPontos, e ficam só os 10 países com melhor pontuação
            _eurovisaoList.Items = _eurovisaoList.Items.OrderByDescending(concorrente => concorrente.TotalPontos).Take(10).ToList();
            int final = _eurovisaoList.Items.Count;
            return final < inicial;
        }

        public bool ExisteConcorrente(string pais) //verifica se existe concorrente pelo nome do país
        {
            return _eurovisaoList.Items.Any(e => e.Pais.Equals(pais));
        }
        public bool ExisteConcorrente(int id) //verifica se existe concorrente pelo id
        {
            return _eurovisaoList.Items.Any(e => e.ID.Equals(id));
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

        public bool ModificarPontosJuri(int pontosJuri, Eurovisao concorrente) // modifica pontos do juri de um concorrente
        {
            if (ReferenceEquals(concorrente, null)) return false;
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.PontosJuri.Equals(pontosJuri));
            if (tIndex > -1)
            {
                _eurovisaoList.Items[tIndex] = concorrente.RegistoConcorrentes();
                return true;
            }
            return false;
        }
        public bool ModificarPontosTelevoto(int pontosTelevoto, Eurovisao concorrente) //modifica pontos do televoto de um concorrente
        {
            if (ReferenceEquals(concorrente, null)) return false;
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.PontosTelevoto.Equals(pontosTelevoto));
            if (tIndex > -1)
            {
                _eurovisaoList.Items[tIndex] = concorrente.RegistoConcorrentes();
                return true;
            }
            return false;
        }
        public bool OrdenarLista() //ordena a lista por ordem descendente de total pontos
        {
            _eurovisaoList.Items = _eurovisaoList.Items.OrderByDescending(concorrente => concorrente.TotalPontos).ToList();
            return true;
        }
        public RegistoConcorrente Vencedor()
        {
            OrdenarLista();
            return _eurovisaoList.Items.FirstOrDefault();
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
                    if (_eurovisaoList.Items.Count > 0)
                    {
                        int tID = _eurovisaoList.Items[0].ID;
                        foreach (RegistoConcorrente r in _eurovisaoList.Items)
                        {
                            if (r.ID > tID) tID = r.ID;
                        }
                        GetNewId.Instancia.ResetProximo(tID); //evita duplicação de Id's
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