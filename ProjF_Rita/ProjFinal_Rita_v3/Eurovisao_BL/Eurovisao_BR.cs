﻿using Eurovisao_BO;
using Eurovisao_DAL;

namespace Eurovisao_BL
{
    public class Eurovisao_BR
    {
        private Eurovisao_DAO _eurovisaoDAO;

        public Eurovisao_BR()
        {
            _eurovisaoDAO = new Eurovisao_DAO();
        }

        //Métodos
        public Eurovisao NovoConcorrente(string pais, string nomeRepresentante, string nomeMusica, int pontosJuri, int pontosTelevoto, int classificacaoFinal)
        {
            string tPais = pais.Trim();
            if (tPais.Length == 0) throw new ArgumentNullException(nameof(tPais));
            string tNomeRepresentante = nomeRepresentante.Trim();
            if (tNomeRepresentante.Length == 0) throw new ArgumentNullException(nameof(tNomeRepresentante));
            string tNomeMusica = nomeMusica.Trim();
            if (tNomeMusica.Length == 0) throw new ArgumentNullException(nameof(tNomeMusica));
            int tPontosJuri = pontosJuri;
            int tPontosTelevoto = pontosTelevoto;
            int tClassificacaoFinal = classificacaoFinal;

            return new Eurovisao(tPais, tNomeRepresentante, tNomeMusica, tPontosJuri, tPontosTelevoto, tClassificacaoFinal);
        }

        public bool AdicionarConcorrente(Eurovisao concorrente) //adiciona concorrente
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.AdicionarConcorrente(concorrente);
        }
        public List<string> GetConcorrentesList() 
        {
            return _eurovisaoDAO.GetConcorrentesList();
        }
        public bool ApagarConcorrente(string pais) //apaga concorrente pelo país
        {
            return _eurovisaoDAO.ApagarConcorrente(pais);
        }

        public bool ExisteConcorrente(string pais) //verica se existe concorrente pelo país
        {
            return _eurovisaoDAO.ExisteConcorrente(pais);
        }
        public bool ExisteConcorrente(int id) //verifica se existe concorrente pelo id
        {
            return _eurovisaoDAO.ExisteConcorrente(id);
        }

        public bool ModificarPontosJuri(int id, int pontosJuri, RegistoConcorrente concorrente) //modifica pontos de juri
        {
            return _eurovisaoDAO.ModificarPontosJuri(id, pontosJuri, concorrente); //nota, gostava que este método e o de baixo fossem ModificarPontos, mas dá erro..
        }
        public bool ModificarPontosTelevoto(int id, int pontosTelevoto, RegistoConcorrente concorrente) //modifica pontos de televoto
        {
            return _eurovisaoDAO.ModificarPontosTelevoto(id, pontosTelevoto, concorrente);
        }
        
        public void ExportarDados()
        {
            _eurovisaoDAO.ExportarDados();
        }
        public bool ImportarDados()
        {
            return _eurovisaoDAO.ImportarDados();
        }
        
    }
}