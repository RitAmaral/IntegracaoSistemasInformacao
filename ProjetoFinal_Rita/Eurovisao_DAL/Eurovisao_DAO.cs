﻿using Eurovisao_BO;
using SerializeTools;
using System.Xml.Serialization;
using ToolBox;
using Eurovisao_Constantes;
using static Eurovisao_BO.RegistoConcorrente;

namespace Eurovisao_DAL
{
    public class Eurovisao_DAO
    {
        [XmlRoot(ElementName = "Concorrentes")]
        public class EurovisaoBD //criar classe, vai representar a base de dados; é composta por uma lista de anotações
        {
            public EurovisaoBD()
            {
                Items = new List<RegistoConcorrente>();
            }

            [XmlElement(ElementName = "Concorrentes")]
            public List<RegistoConcorrente> Items { get; set; }
        }
        private EurovisaoBD _eurovisaoList;
        private DateTime _loaded; //variaveis adicionadas (_loaded e _modified) para o momento em que carreguei, e quando foi modificada
        private DateTime _modified;

        public Eurovisao_DAO()
        {
            _eurovisaoList = new EurovisaoBD();
        }
        //Métodos
        public bool AdicionarConcorrente(Eurovisao concorrente) //Adicionar pais concorrente na eurovisão
        {
            if (ReferenceEquals(concorrente, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            _eurovisaoList.Items.Add(concorrente.RegistoConcorrentes());
            _modified = DateTime.Now;
            return true;
        }
        public bool AdicionarAnotacao(RegistoConcorrente concorrente)
        { 
            _eurovisaoList.Items.Add(concorrente); //adiciona à lista
            _modified = DateTime.Now;
            return true;
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
                    _modified = DateTime.Now;
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
            if (_modified > _loaded || !File.Exists(Constantes.NomeXmlEurovisao))
            {
                try
                {
                    ExportarXml(Constantes.NomeXmlEurovisao);
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
                    _loaded = DateTime.Now;
                    _modified = DateTime.Now;
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
    }
}