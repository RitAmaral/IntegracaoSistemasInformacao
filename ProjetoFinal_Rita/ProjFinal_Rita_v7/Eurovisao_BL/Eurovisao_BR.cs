using Eurovisao_BO;
using Eurovisao_Constantes;
using Eurovisao_DAL;

namespace Eurovisao_BL
{
    public class Eurovisao_BR : IEurovisaoMetodos //implementar a interface IEurovisaoMetodos: garante que Eurovisao_BR implemente todos os métodos definidos na interface.
    {
        private Eurovisao_DAO _eurovisaoDAO;

        public Eurovisao_BR()
        {
            _eurovisaoDAO = new Eurovisao_DAO();
        }

        //Métodos
        public Eurovisao NovoConcorrente(string pais, string nomeRepresentante, string nomeMusica, Ronda ronda, int pontosJuri, int pontosTelevoto)
        {
            string tPais = pais.Trim();
            if (tPais.Length == 0) throw new ArgumentNullException(nameof(tPais));
            string tNomeRepresentante = nomeRepresentante.Trim();
            if (tNomeRepresentante.Length == 0) throw new ArgumentNullException(nameof(tNomeRepresentante));
            string tNomeMusica = nomeMusica.Trim();
            if (tNomeMusica.Length == 0) throw new ArgumentNullException(nameof(tNomeMusica));
            Ronda tRonda = ronda;
            int tPontosJuri = pontosJuri;
            int tPontosTelevoto = pontosTelevoto;

            return new Eurovisao(tPais, tNomeRepresentante, tNomeMusica, tRonda, tPontosJuri, tPontosTelevoto);
        }

        public bool AdicionarConcorrente(Eurovisao concorrente) //adiciona concorrente
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.AdicionarConcorrente(concorrente);
        }

        public List<string> GetConcorrentesList() //obter lista de concorrentes
        {
            return _eurovisaoDAO.GetConcorrentesList();
        }
        public bool ApagarConcorrente(string pais) //apaga concorrente pelo país
        {
            return _eurovisaoDAO.ApagarConcorrente(pais);
        }
        public bool ApagarConcClassificacaoFinal() //apaga concorrentes com menores pontuações
        {
            return _eurovisaoDAO.ApagarConcClassificacaoFinal();
        }

        public bool ExisteConcorrente(string pais) //verica se existe concorrente pelo país
        {
            return _eurovisaoDAO.ExisteConcorrente(pais);
        }
        public bool ExisteConcorrente(int id) //verifica se existe concorrente pelo id
        {
            return _eurovisaoDAO.ExisteConcorrente(id);
        }
        
        public bool ModificarPontosJuri(int pontosJuri, Eurovisao concorrente) //modifica pontos de juri
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarPontosJuri(pontosJuri, concorrente); //nota, gostava que este método e o de baixo fossem ModificarPontos, mas dá erro..
        }
        
        public bool ModificarPontosTelevoto(int pontosTelevoto, Eurovisao concorrente) //modifica pontos de televoto
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarPontosTelevoto(pontosTelevoto, concorrente);
        }
        public bool ModificarRondaConcorrente(string pais, Ronda ronda, Eurovisao concorrente) //modifica ronda
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarRondaConcorrente(pais, ronda, concorrente);
        }
        public bool OrdernarLista()
        {
            return _eurovisaoDAO.OrdenarLista();
        }
        public RegistoConcorrente Vencedor()
        {
            return _eurovisaoDAO.Vencedor();
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