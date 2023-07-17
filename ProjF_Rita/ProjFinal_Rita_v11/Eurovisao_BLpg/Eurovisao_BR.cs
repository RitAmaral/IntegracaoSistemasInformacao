using Eurovisao_BOpg;
using Eurovisao_Configuration;
using Eurovisao_Constantes;
using Eurovisao_DALpg;
using Eurovisao_Models2Api;
using Npgsql;
using System.Data;

namespace Eurovisao_BLpg
{
    public class Eurovisao_BR 
    {
        private NpgsqlConnection _conn;
        private Eurovisao_DAO _eurovisaoDAO;

        /// <summary>
        /// construtor
        /// </summary>
        public Eurovisao_BR()
        {
            _conn = new NpgsqlConnection(GlobalConfig.Instancia.NpgsqlConnection);
            _eurovisaoDAO = new Eurovisao_DAO(_conn);
        }

        /// <summary>
        /// destrutor é necessário para terminar a ligação com a base de dados
        /// </summary>
        ~Eurovisao_BR()
        {
            if (_conn.State == ConnectionState.Open) _conn.Close();
            _conn.Dispose();
        }

        //Métodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pais"></param>
        /// <param name="nomeRepresentante"></param>
        /// <param name="nomeMusica"></param>
        /// <param name="ronda"></param>
        /// <param name="pontosJuri"></param>
        /// <param name="pontosTelevoto"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="concorrente"></param>
        /// <returns></returns>
        public bool AdicionarConcorrente(Eurovisao concorrente) //adiciona concorrente
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.AdicionarConcorrente(concorrente);
        }

        public List<string> GetConcorrentesList() //obter lista de concorrentes
        {
            return _eurovisaoDAO.GetConcorrentesList();
        }
        /*
        public List<string> GetConcorrentesList(Ronda ronda) //obter lista de concorrentes
        {
            return _eurovisaoDAO.GetConcorrentesList(ronda);
        }
        */
        public List<Eurovisao> GetConcorrentes(Ronda ronda) //obter lista de concorrentes
        {
            return _eurovisaoDAO.GetConcorrentes(ronda);
        }

        public bool ApagarConcorrente(string pais) //apaga concorrente pelo país
        {
            return _eurovisaoDAO.ApagarConcorrente(pais);
        }


        public bool ModificarConcorrente(int id, Eurovisao concorrente) //necessário por causo do método ModificarConcorrenteRequest em baixo
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarConcorrente(id, concorrente);
        }
        public bool ModificarPontosJuri(int pontosJuri, Eurovisao concorrente) //necessário por causo do método ModificarConcorrenteRequest em baixo
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarConcorrente(pontosJuri, concorrente);
        }

        public bool ModificarPontosTelevoto(int pontosTelevoto, Eurovisao concorrente) //necessário por causo do método ModificarConcorrenteRequest em baixo
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarConcorrente(pontosTelevoto, concorrente);
        }

        /*
        public bool ModificarRondaConcorrente(string pais, Ronda ronda, Eurovisao concorrente) //modifica ronda, nota: vou mudar por enum.parse no program
        {
            if (ReferenceEquals(concorrente, null)) return false;
            return _eurovisaoDAO.ModificarRondaConcorrente(pais, ronda, concorrente);
        }
        */

        public bool ExisteConcorrente(string pais, out Eurovisao? obj) //verica se existe concorrente pelo país
        {
            obj = null;
            return _eurovisaoDAO.ExisteConcorrente(pais);
        }

        public bool ExisteConcorrente(int id)
        {
            return _eurovisaoDAO.ExisteConcorrente(id);
        }

        /*---------------------Serviçõs para o API--------------------*/
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
            if (ExisteConcorrente(id, out obj)) //mesmo que só queira alterar alguns atributos, colocar todos, e depois colocar o mesmo nome nos que não quero alterar
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

        public bool OrdernarLista()
        {
            return _eurovisaoDAO.OrdenarLista();
        }
        public Eurovisao Vencedor() //mostra vencendor da eurovisão
        {
            return _eurovisaoDAO.Vencedor();
        }
    }
}
