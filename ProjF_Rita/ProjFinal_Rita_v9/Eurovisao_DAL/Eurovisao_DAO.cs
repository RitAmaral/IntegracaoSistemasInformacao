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
        public List<string> GetConcorrentesList(string ronda) //mostra lista de concorrentes por ronda
        {
            List<string> list = new List<string>();
            foreach (RegistoConcorrente concorrente in _eurovisaoList.Items)
            {
                if (concorrente.Ronda == ronda)
                {
                    list.Add(concorrente.ToString());
                }
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
                //apagar todos os registos com o nome igual ao "país"
                if (_eurovisaoList.Items.RemoveAll(r => r.Pais.Equals(pais)) > 0) //se for maior que 0, significa que eliminou pelo menos 1 registo.
                {
                    return true;
                }
            }
            return false;
        }
        public bool ApagarConcorrente(int id) //apaga concorrente pelo id do país que representa
        {
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.ID.Equals(id));
            if (tIndex > -1)
            {
                _eurovisaoList.Items.RemoveAt(tIndex);
                return true;
            }
            return false;
        }
        public bool ApagarConcClassificacaoFinal() //apagar concorrentes com menores pontuações
        {
            int inicial = _eurovisaoList.Items.Count;
            //ordena a lista por ordem descendente de TotalPontos, e ficam só os 10 países com melhor pontuação
            _eurovisaoList.Items = _eurovisaoList.Items.OrderByDescending(concorrente => concorrente.TotalPontos).Take(10).ToList();
            int final = _eurovisaoList.Items.Count;
            return final < inicial; //se a lista inicial tiver mais concorrentes que a lista final, então conc foram removidos (return true)
        }

        public bool ApagarConcRonda(string ronda) //apaga concorrentes por ronda, por semifinal1 ou por semifinal2
        {
            int inicial = _eurovisaoList.Items.Count;            
            var concRonda = _eurovisaoList.Items.Where(concorrente => concorrente.Ronda == ronda).ToList(); //Filtra os concorrentes por ronda
            concRonda = concRonda.OrderByDescending(concorrente => concorrente.TotalPontos).ToList(); //Ordena a lista de conc da ronda por ordem decrescente de TotalPontos
            
            if (concRonda.Count > 10) //se a lista tiver mais que 10 concorrentes, então vai eliminar os que estão a mais
            {
                concRonda = concRonda.Take(10).ToList(); //remove os concorrentes, só ficam os 10 melhores de cada ronda
            }

            _eurovisaoList.Items.RemoveAll((Predicate<RegistoConcorrente>)(concorrente => concorrente.Ronda == ronda)); //Remove os conc da ronda da lista geral de concorrentes           
            _eurovisaoList.Items.AddRange(concRonda); //Adiciona novamente os concorrentes selecionados para a final

            int final = _eurovisaoList.Items.Count;
            return final < inicial; //se a lista inicial tiver mais concorrentes que a lista final, então conc foram removidos (return true)
        }

        public bool ExisteConcorrente(string pais) //verifica se existe concorrente pelo nome do país
        {
            return _eurovisaoList.Items.Any(e => e.Pais.Equals(pais));
        }
        public bool ExisteConcorrente(int id) //verifica se existe concorrente pelo id
        {
            return _eurovisaoList.Items.Any(e => e.ID.Equals(id));
        }
        public bool ExisteConcorrente(string pais, out Eurovisao? obj) //este existe concorrente é necessário para o método apagar concorrente em cima
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
        public bool ExisteConcorrente(int id, out Eurovisao? obj) //este existe concorrente por id é necessário para JSON
        {
            obj = null;
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.ID.Equals(id));
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
        public bool ModificarConcorrente(int id, Eurovisao concorrente)
        {
            if (ReferenceEquals(concorrente, null)) return false;
            int tIndex = _eurovisaoList.Items.FindIndex(r => r.ID.Equals(id));
            if (tIndex > -1)
            {
                _eurovisaoList.Items[tIndex] = concorrente.RegistoConcorrentes();
                return true;
            }
            return false;
        }
        /*
        public bool ModificarRondaConcorrente(string pais, Ronda ronda, Eurovisao concorrente) //modifica as rondas: semifinal1, semifinal2, final
        {
            if(ReferenceEquals(concorrente, null)) return false;
            int tIndex = _eurovisaoList.Items.FindIndex(c => c.Pais.Equals(pais));
            if (tIndex > -1)
            {
                _eurovisaoList.Items[tIndex] = concorrente.RegistoConcorrentes();
                return true;
            }
            return false;
        }
        */
        public bool OrdenarLista() //ordena a lista por ordem descendente de total pontos
        {
            _eurovisaoList.Items = _eurovisaoList.Items.OrderByDescending(concorrente => concorrente.TotalPontos).ToList();
            return true;
        }
        public RegistoConcorrente Vencedor() //diz o vencedor da eurovisão após lista ordenada por ordem descendente de total pontos
        {
            OrdenarLista();
            return _eurovisaoList.Items.FirstOrDefault();
        }
        public List<string> Historico() //mostra o historico, no entanto so dos paises que estão na final, não os que já foram eliminados da lista..
        {
            List<string> historico = new List<string>();
            Console.WriteLine($"País\t| Ronda\t| Júri\t| Televoto\t| Total de Pontos");

            foreach (RegistoConcorrente concorrente in _eurovisaoList.Items)
            {
                string resultado = $"{concorrente.Pais}\t| {concorrente.Ronda}\t| {concorrente.PontosJuri}\t| {concorrente.PontosTelevoto}\t| {concorrente.TotalPontos}";
                historico.Add(resultado);
            }

            return historico;
        }
 
        //XML
        public void ExportarDados()
        {
            string ficheiro = System.IO.Path.Combine(System.AppContext.BaseDirectory, Constantes.NomeXmlEurovisao);
            if (!File.Exists(ficheiro))
            {
                try
                {
                    ExportarXml(ficheiro);
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
            string ficheiro = System.IO.Path.Combine(System.AppContext.BaseDirectory, Constantes.NomeXmlEurovisao);
            return ImportarXml(ficheiro);
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
        //serviços para o API
        public List<Eurovisao> GetConcorrentes()
        {
            List<Eurovisao> list = new List<Eurovisao>();
            foreach (RegistoConcorrente c in _eurovisaoList.Items)
            {
                list.Add(new Eurovisao(c));
            }
            return list;
        }
    }
}