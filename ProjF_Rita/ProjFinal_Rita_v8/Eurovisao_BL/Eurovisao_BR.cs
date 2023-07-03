using Eurovisao_BO;
using Eurovisao_Constantes;
using Eurovisao_DAL;
using Eurovisao_Models2Api;

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
        public List<string> GetConcorrentesList(Ronda ronda) //obter lista de concorrentes por ronda
        {
            return _eurovisaoDAO.GetConcorrentesList(ronda);
        }
        public bool ApagarConcorrente(string pais) //apaga concorrente pelo país
        {
            return _eurovisaoDAO.ApagarConcorrente(pais);
        }
        public bool ApagarConcClassificacaoFinal() //apaga concorrentes com menores pontuações
        {
            return _eurovisaoDAO.ApagarConcClassificacaoFinal();
        }
        public bool ApagarConcRonda(Ronda ronda) //apaga concorrentes por ronda, por semifinal1 ou por semifinal2
        {
            return _eurovisaoDAO.ApagarConcRonda(ronda);
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
        public bool ModificarConcorrente(int id, Eurovisao concorrente)
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarConcorrente(id, concorrente);
        }
        /*
        public bool ModificarRondaConcorrente(string pais, Ronda ronda, Eurovisao concorrente) //modifica ronda, nota: vou mudar por enum.parse no program
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarRondaConcorrente(pais, ronda, concorrente);
        }
        */
        public List<string> Historico() //mostra historico
        {
            return _eurovisaoDAO.Historico();
        }
        public bool OrdernarLista()
        {
            return _eurovisaoDAO.OrdenarLista();
        }
        public RegistoConcorrente Vencedor()
        {
            return _eurovisaoDAO.Vencedor();
        }
        //XML
        public void ExportarDados()
        {
            _eurovisaoDAO.ExportarDados();
        }
        public bool ImportarDados()
        {
            return _eurovisaoDAO.ImportarDados();
        }
        //serviços para o API
        public List<EuroRegistoResponse> GetConcorrenteListResponse() //adicionar dependencia do eurovisao Models
        {
            List<EuroRegistoResponse> lista = new List<EuroRegistoResponse>();
            foreach (var c in _eurovisaoDAO.GetConcorrentes()) // é preciso criar este método na Eurovisao_DAO
            {
                lista.Add(c.RegistoConcorrenteResponse());
            }
            return lista;
        }
        public bool ExisteConcorrente(int id, out Eurovisao? obj) // é preciso criar este método na Eurovisao_DAO
        {
            obj = null;
            return _eurovisaoDAO.ExisteConcorrente(id, out obj);
        }
        public EuroRegistoResponse ObterConcorrenteResponse(int id)
        {
            EuroRegistoResponse? obj = null;
            Eurovisao? concorrente = null;
            if (ExisteConcorrente(id, out concorrente)) 
            {
                obj = new EuroRegistoResponse
                {
                    ID = concorrente.ID,
                    Pais = concorrente.Pais,
                    NomeRepresentante = concorrente.NomeRepresentante,
                    NomeMusica = concorrente.NomeMusica,
                    Ronda = concorrente.Ronda,
                    PontosJuri = concorrente.PontosJuri,
                    PontosTelevoto = concorrente.PontosTelevoto
                };
            }
            return obj;
        }
        public bool AdicionarConcorrenteRequest(EuroRegistoRequest request)
        {
            Eurovisao concorrente = NovoConcorrente( //o id é gerado automaticamente, por isso não é preciso colocar aqui
                request.Pais,
                request.NomeRepresentante,
                request.NomeMusica,
                request.Ronda,
                request.PontosJuri,
                request.PontosTelevoto);
            return AdicionarConcorrente(concorrente);
        }
        public bool ModificarConcorrenteRequest(int id, EuroRegistoRequest request)
        {
            Eurovisao? obj = null;
            if (ExisteConcorrente(id, out obj)) //msm que só queira alterar alguns atributos, colocar todos, e depois colocar o msm nome nos que nao quero alterar
            {
                obj.Pais = request.Pais;
                obj.NomeRepresentante = request.NomeRepresentante;
                obj.NomeMusica = request.NomeMusica;
                obj.Ronda = request.Ronda;
                obj.PontosJuri = request.PontosJuri;
                obj.PontosTelevoto = request.PontosTelevoto;
                return ModificarConcorrente(id, obj);
            }
            return false;
        }
        public bool ApagarConcorrente(int id) 
        {
            return _eurovisaoDAO.ApagarConcorrente(id);
        }
    }
}
