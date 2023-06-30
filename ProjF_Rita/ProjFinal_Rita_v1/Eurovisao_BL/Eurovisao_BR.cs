using Eurovisao_BO;
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
        public Eurovisao NovoConcorrente(string pais, string nomeRepresentante, string nomeMusica, int pontosJuri, int pontosTelevoto, int totalPontos, int classificacaoFinal)
        {
            string tPais = pais.Trim();
            if (tPais.Length == 0) throw new ArgumentNullException(nameof(tPais));
            string tNomeRepresentante = nomeRepresentante.Trim();
            if (tNomeRepresentante.Length == 0) throw new ArgumentNullException(nameof(tNomeRepresentante));
            string tNomeMusica = nomeMusica.Trim();
            if (tNomeMusica.Length == 0) throw new ArgumentNullException(nameof(tNomeMusica));
            int tPontosJuri = pontosJuri;
            int tPontosTelevoto = pontosTelevoto;
            int tTotalPontos = totalPontos;
            int tClassificacaoFinal = classificacaoFinal;

            return new Eurovisao(tPais, tNomeRepresentante, tNomeMusica, tPontosJuri, tPontosTelevoto, tTotalPontos, tClassificacaoFinal);
        }

        public bool AdicionarConcorrente(Eurovisao concorrente)
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.AdicionarConcorrente(concorrente);
        }
        public List<string> GetConcorrentesList()
        {
            return _eurovisaoDAO.GetConcorrentesList();
        }
        public bool ApagarConcorrente(string pais)
        {
            return _eurovisaoDAO.ApagarConcorrente(pais);
        }
        public bool ExisteConcorrente(string pais)
        {
            return _eurovisaoDAO.ExisteConcorrente(pais);
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