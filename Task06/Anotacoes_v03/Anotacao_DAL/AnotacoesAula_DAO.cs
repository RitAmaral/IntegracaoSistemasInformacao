using Anotacao_BO;
using System.Xml.Serialization;
using Anotacoes_Constantes;
using SerializeTools;
using static Anotacao_BO.RegistoAnotacao;
using ToolBox;

namespace Anotacao_DAL
{
    public class AnotacoesAula_DAO
    {
        [XmlRoot(ElementName = "Anotacoes")]
        public class AnotacoesBD //criar classe, vai representar a base de dados; é composta por uma lista de anotações
        {
            public AnotacoesBD()
            {
                Items = new List<RegistoAnotacao>();
            }

            [XmlElement(ElementName = "Anotacao")]
            public List<RegistoAnotacao> Items { get; set; }
        }

        //Criação da lista
        //private List<AnotacoesAula> _anotacoesList;
        private AnotacoesBD _anotacoesList;

        public AnotacoesAula_DAO()
        {
            _anotacoesList = new AnotacoesBD();
        }

        //Métodos
        public bool AdicionarAnotacao(AnotacoesAula anotacao)
        {
            if (ReferenceEquals(anotacao, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            return AdicionarAnotacao(anotacao.RegistoAnotacao());
        }
        public bool AdicionarAnotacao(RegistoAnotacao anotacao)
        { // um struct está sempre preenchido
            _anotacoesList.Items.Add(anotacao); //adiciona à lista
            return true;
        }
        public List<string> GetAnotacoesList() 
        {
            List<string> list = new List<string>();
            foreach (RegistoAnotacao c in _anotacoesList.Items)
            {
                list.Add(c.ToString());
            }
            return list;
        }
        public bool ApagarAnotacao(string nome) //apagar pelo nome
        {
            AnotacoesAula? obj = null;
            string tNome = nome.Trim();
            if (ExisteAnotacao(tNome, out obj))
            {
                if (ReferenceEquals(obj, null)) return false;
                // apagar todos os registos com o nome igual ao "nome"
                if (_anotacoesList.Items.RemoveAll(r => r.Nome.Equals(nome)) > 0) //se for maior que 0, significa que eliminou pelo menos 1 registo.
                {
                    return true;
                }
            }
            return false;
        }
        public bool ApagarAnotacao(int id) //apagar pelo id
        {
            int tIndex = _anotacoesList.Items.FindIndex(r => r.Id.Equals(id));
            if (tIndex > -1)
            {
                _anotacoesList.Items.RemoveAt(tIndex);
                return true;
            }
            return false;
        }
        public bool ExisteAnotacao(string nome) //existe anotação pelo nome
        {
            AnotacoesAula? obj = null;
            return ExisteAnotacao(nome, out obj);
        }
        public bool ExisteAnotacao(int id, out AnotacoesAula? obj) //existe anotação pelo id
        {
            obj = null;
            int tIndex = _anotacoesList.Items.FindIndex(r => r.Id.Equals(id));
            if (tIndex > -1)
            {
                obj = new AnotacoesAula(_anotacoesList.Items[tIndex]);
                return true;
            }
            return false;
        }

        public bool ExisteAnotacao(string nome, out AnotacoesAula? obj) //acrescentar
        {
            obj = null;
            string tNome = nome.Trim();
            if (tNome.Length == 0) return false;
            int tIndex = _anotacoesList.Items.FindIndex(r => r.Nome.Equals(nome));
            if (tIndex > -1)
            {
                obj = new AnotacoesAula(_anotacoesList.Items[tIndex]);
                return true;
            }
            return false;
        }
        public bool ModificarAnotacao(int id, AnotacoesAula anotacao) //modifica id da anotação
        {
            if (ReferenceEquals(anotacao, null)) return false;
            int tIndex = _anotacoesList.Items.FindIndex(r => r.Id.Equals(id));
            if (tIndex > -1)
            {
                _anotacoesList.Items[tIndex] = anotacao.RegistoAnotacao();
                return true;
            }
            return false;
        }
        public void ExportarDados() //exporta dados
        {
            string ficheiro = System.IO.Path.Combine(System.AppContext.BaseDirectory, Constantes.NomeXmlAnotacoes);
            if (!File.Exists(ficheiro))
            {
                try
                {
                    ExportarXml(Constantes.NomeXmlAnotacoes);
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
                    XmlMethods.SerializeToXml<AnotacoesBD>(_anotacoesList, ficheiro);

                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return false;
        }
        public bool ImportarDados() //importa dados
        {
            string ficheiro = System.IO.Path.Combine(System.AppContext.BaseDirectory, Constantes.NomeXmlAnotacoes);
            return ImportarXml(ficheiro);
        }
        public bool ImportarXml(string ficheiro)
        {
            if (ficheiro != null && File.Exists(ficheiro))
            {
                try
                {
                    _anotacoesList = XmlMethods.DeserializeXmlToObject<AnotacoesBD>(ficheiro);
                    // uma proposta de solução para evitar duplicação de Id's
                    // estratégia para se atualizar o gerador de Id's
                    if (_anotacoesList.Items.Count > 0)
                    {
                        int tId = _anotacoesList.Items[0].Id;
                        foreach (RegistoAnotacao r in _anotacoesList.Items)
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
        //serviços para o API
        public List<AnotacoesAula> GetAnotacoes()
        {
            List<AnotacoesAula> list = new List<AnotacoesAula>();
            foreach (RegistoAnotacao c in _anotacoesList.Items)
            {
                list.Add(new AnotacoesAula(c));
            }
            return list;
        }
    }
}