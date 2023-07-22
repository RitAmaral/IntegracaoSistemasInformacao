using Eurovisao_BOpg;
using Npgsql;
using System.Data;
using Eurovisao_Constantes;
using System.Reflection;


namespace Eurovisao_DALpg
{
    public class Eurovisao_DAO
    {

        private NpgsqlConnection _conn;

        public Eurovisao_DAO(NpgsqlConnection _conn)
        {
            this._conn = _conn;
        }

        public NpgsqlConnection Db => _conn;

        public void DbOpen()
        {
            if (Db.State != ConnectionState.Open) Db.Open();

        }

        public void DbClose()
        {
            if (Db.State == ConnectionState.Open) Db.Close();
        }


        //Métodos
        public bool AdicionarConcorrente(Eurovisao concorrente) //Adicionar concorrente na eurovisão
        {
            if (ReferenceEquals(concorrente, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            string sqltxt = "INSERT INTO public.concorrentes (pais, nomerepresentante, nomemusica, ronda, pontosjuri, pontostelevoto, totalpontos) " +
                "VALUES (@pais, @nomerepresentante, @nomemusica, @ronda, @pontosjuri, @pontostelevoto, @totalpontos);";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@pais", concorrente.Pais);
                com1.Parameters.AddWithValue("@nomerepresentante", concorrente.NomeRepresentante);
                com1.Parameters.AddWithValue("@nomemusica", concorrente.NomeMusica);
                com1.Parameters.AddWithValue("@ronda", (int)concorrente.Ronda);
                com1.Parameters.AddWithValue("@pontosjuri", concorrente.PontosJuri);
                com1.Parameters.AddWithValue("@pontostelevoto", concorrente.PontosTelevoto);
                com1.Parameters.AddWithValue("@totalpontos", concorrente.TotalPontos);
                int resultado = com1.ExecuteNonQuery();
                tr.Commit();
                tr.Dispose();
                tr = null;
                com1.Dispose();
                return resultado != -1;
            }
            catch (Exception e)
            {
                if (tr != null)
                {
                    tr.Rollback();
                    tr.Dispose();
                }
                throw new Exception("Erro ao adicionar concorrente!", e);
            }
        }


        public List<string> GetConcorrentesList() //mostra lista de concorrentes
        {
            List<string> list = new List<string>();
            string sqltxt = "SELECT id, pais, nomeRepresentante, nomeMusica FROM public.concorrentes;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int tmpID = res1.GetInt32(res1.GetOrdinal("id"));
                        string tmpPais = res1["pais"].ToString();
                        string tmpNomeRepresentante = res1["nomeRepresentante"].ToString();
                        string tmpNomeMusica = res1["nomeMusica"].ToString();

                        list.Add($"{tmpID}, {tmpPais}\t{tmpNomeRepresentante}, {tmpNomeMusica}");
                    }
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de concorrentes!", e);
            }
            return list;
        }
        /*
        public List<string> GetConcorrentesList(Ronda ronda) //mostra lista de concorrentes
        {
            List<string> list = new List<string>();
            string sqltxt = "SELECT id, pais, nomeRepresentante, nomeMusica, ronda FROM public.concorrentes WHERE ronda=@ronda;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int tmpID = res1.GetInt32(res1.GetOrdinal("id"));
                        string tmpPais = res1["pais"].ToString();
                        string tmpNomeRepresentante = res1["nomeRepresentante"].ToString();
                        string tmpNomeMusica = res1["nomeMusica"].ToString();
                        Ronda tmpRonda = (Ronda)res1.GetByte(res1.GetOrdinal("ronda"));

                        list.Add($"{tmpID}, {tmpPais}\t{tmpNomeRepresentante}, {tmpNomeMusica}");
                    }
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de compromissos!", e);
            }
            return list;
        }
        */


        public bool ApagarConcorrente(string pais) //apaga concorrente pelo nome do país que representa
        {
            Eurovisao? obj = null;
            string tPais = pais.Trim();
            int contador = 0;
            while (ExisteConcorrente(tPais, out obj))
            {
                if (ApagarConcorrente(obj.ID))
                {
                    contador++;
                }
                else
                {
                    //não conseguiu apagar, deve-se interromper para evitar loop infinito...
                    break;
                }
            }
            return contador > 0;
        }

        public bool ApagarConcorrente(int id) //apaga concorrente pelo id do país que representa
        {
            string sqltxt = "DELETE FROM public.concorrentes WHERE id=@id;";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@id", id);
                int resultado = com1.ExecuteNonQuery();
                tr.Commit();
                tr.Dispose();
                tr = null;
                com1.Dispose();
                return resultado != -1;
            }
            catch (Exception e)
            {
                if (tr != null)
                {
                    tr.Rollback();
                    tr.Dispose();
                }
                throw new Exception("Erro ao apagar concorrente!", e);
            }

        }


        public bool ExisteConcorrente(string pais) //verifica se existe concorrente pelo nome do país
        {
            Eurovisao? obj = null;
            return ExisteConcorrente(pais, out obj);
        }

        public bool ExisteConcorrente(int id) //verifica se existe concorrente pelo nome do país
        {
            Eurovisao? obj = null;
            return ExisteConcorrente(id, out obj);
        }

        public bool ExisteConcorrente(string pais, out Eurovisao? obj) //este existe concorrente é necessário para o método apagar concorrente em cima
        {
            obj = null;
            string tPais = pais.Trim();
            if (tPais.Length == 0) return false;
            string sqltxt = "SELECT id FROM public.concorrentes WHERE pais=@pais;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                qry1.Parameters.AddWithValue("@pais", tPais);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows && res1.Read())
                {
                    int id = res1.GetInt32(res1.GetOrdinal("id"));
                    res1.Close();
                    return ExisteConcorrente(id, out obj);
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter concorrente por pais!", e);
            }
            return false;
        }

        public bool ExisteConcorrente(int id, out Eurovisao? obj) //este existe concorrente por id é necessário para JSON
        {
            bool resultado = false;
            obj = null;
            string sqltxt = "SELECT id, pais, nomerepresentante, nomemusica, ronda, pontosjuri, pontostelevoto " +
                "FROM public.concorrentes WHERE id=@id;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                qry1.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows && res1.Read())
                {
                    string tmpPais = res1["pais"].ToString();
                    string tmpNomeRepresentante = res1["nomerepresentante"].ToString();
                    string tmpNomeMusica = res1["nomemusica"].ToString();
                    Ronda tmpRonda = (Ronda)res1.GetByte(res1.GetOrdinal("ronda"));
                    byte tmpPontosJuri = res1.GetByte(res1.GetOrdinal("pontosjuri"));
                    byte tmpPontosTelevoto = res1.GetByte(res1.GetOrdinal("pontostelevoto"));
                    res1.Close();
                    obj = new Eurovisao(id, tmpPais, tmpNomeRepresentante, tmpNomeMusica, tmpRonda, tmpPontosJuri, tmpPontosTelevoto);
                    resultado = true;
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter concorrente por id!", e);
            }
            return resultado;
        }

        public bool ModificarConcorrente(int id, Eurovisao concorrente) 
        {
            if (ReferenceEquals(concorrente, null)) return false;
            string sqltxt = "UPDATE public.concorrentes SET pais=@pais, nomerepresentante=@nomerepresentante, nomemusica=@nomemusica " +
                "ronda=@ronda, pontosjuri=@pontosjuri, pontostelevoto=@pontostelevoto, totalpontos=@totalpontos WHERE id=@id;";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@pais", concorrente.Pais);
                com1.Parameters.AddWithValue("@nomerepresentante", concorrente.NomeRepresentante);
                com1.Parameters.AddWithValue("@nomemusica", concorrente.NomeMusica);
                com1.Parameters.AddWithValue("@ronda", (int)concorrente.Ronda);
                com1.Parameters.AddWithValue("@pontosjuri", concorrente.PontosJuri);
                com1.Parameters.AddWithValue("@pontostelevoto", concorrente.PontosTelevoto);
                com1.Parameters.AddWithValue("@totalpontos", concorrente.TotalPontos);
                int resultado = com1.ExecuteNonQuery();
                tr.Commit();
                tr.Dispose();
                tr = null;
                com1.Dispose();
                return resultado == 1;
            }

            catch (Exception e)
            {
                if (tr != null)
                {
                    tr.Rollback();
                    tr.Dispose();
                }
                throw new Exception("Erro ao modificar concorrente!", e);
            }
        }

        public bool ModificarPontosJuri(int pontosJuri, Eurovisao concorrente) 
        {
            if (ReferenceEquals(concorrente, null)) return false;
            string sqltxt = "UPDATE public.concorrentes SET pais=@pais, nomerepresentante=@nomerepresentante, nomemusica=@nomemusica " +
                "ronda=@ronda, pontosjuri=@pontosjuri, pontostelevoto=@pontostelevoto, totalpontos=@totalpontos WHERE pontosjuri=@pontosjuri;";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@pais", concorrente.Pais);
                com1.Parameters.AddWithValue("@nomerepresentante", concorrente.NomeRepresentante);
                com1.Parameters.AddWithValue("@nomemusica", concorrente.NomeMusica);
                com1.Parameters.AddWithValue("@ronda", (int)concorrente.Ronda);
                com1.Parameters.AddWithValue("@pontosjuri", concorrente.PontosJuri);
                com1.Parameters.AddWithValue("@pontostelevoto", concorrente.PontosTelevoto);
                com1.Parameters.AddWithValue("@totalpontos", concorrente.TotalPontos);
                int resultado = com1.ExecuteNonQuery();
                tr.Commit();
                tr.Dispose();
                tr = null;
                com1.Dispose();
                return resultado == 1;
            }

            catch (Exception e)
            {
                if (tr != null)
                {
                    tr.Rollback();
                    tr.Dispose();
                }
                throw new Exception("Erro ao modificar pontos do júri do concorrente!", e);
            }
        }

        public bool ModificarPontosTelevoto(int pontosTelevoto, Eurovisao concorrente)
        {
            if (ReferenceEquals(concorrente, null)) return false;
            string sqltxt = "UPDATE public.concorrentes SET pais=@pais, nomerepresentante=@nomerepresentante, nomemusica=@nomemusica " +
                "ronda=@ronda, pontosjuri=@pontosjuri, pontostelevoto=@pontostelevoto, totalpontos=@totalpontos WHERE pontostelevoto=@pontostelevoto;";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@pais", concorrente.Pais);
                com1.Parameters.AddWithValue("@nomerepresentante", concorrente.NomeRepresentante);
                com1.Parameters.AddWithValue("@nomemusica", concorrente.NomeMusica);
                com1.Parameters.AddWithValue("@ronda", (int)concorrente.Ronda);
                com1.Parameters.AddWithValue("@pontosjuri", concorrente.PontosJuri);
                com1.Parameters.AddWithValue("@pontostelevoto", concorrente.PontosTelevoto);
                com1.Parameters.AddWithValue("@totalpontos", concorrente.TotalPontos);
                int resultado = com1.ExecuteNonQuery();
                tr.Commit();
                tr.Dispose();
                tr = null;
                com1.Dispose();
                return resultado == 1;
            }

            catch (Exception e)
            {
                if (tr != null)
                {
                    tr.Rollback();
                    tr.Dispose();
                }
                throw new Exception("Erro ao modificar pontos do televoto do concorrente!", e);
            }
        }

        public List<Eurovisao> GetConcorrentes()
        {
            List<Eurovisao> list = new List<Eurovisao>();
            string sqltxt = "SELECT id, pais, nomeRepresentante, nomeMusica FROM public.concorrentes;";

            try
            {
                // passo 1
                // é necessário obter uma lista de id da tabela
                List<int> listaIds = new List<int>();
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int tmpID = res1.GetInt32(res1.GetOrdinal("id"));
                        listaIds.Add(tmpID);
                    }
                }
                if (!res1.IsClosed) res1.Close();

                // passo 2
                // obter objetos e criar a lista
                Eurovisao? obj;
                foreach (int id in listaIds)
                {
                    if (ExisteConcorrente(id, out obj))
                    {
                        list.Add(obj);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de concorrentes!", e);
            }
            return list;
        }

        public List<Eurovisao> GetConcorrentes(Ronda ronda)
        {
            List<Eurovisao> list = new List<Eurovisao>();
            string sqltxt = "SELECT id, pais, nomeRepresentante, nomeMusica FROM public.concorrentes WHERE ronda=@ronda;";

            try
            {
                // passo 1
                // é necessário obter uma lista de id da tabela
                List<int> listaIds = new List<int>();
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int tmpID = res1.GetInt32(res1.GetOrdinal("id"));
                        listaIds.Add(tmpID);
                    }
                }
                if (!res1.IsClosed) res1.Close();

                // passo 2
                // obter objetos e criar a lista
                Eurovisao? obj;
                foreach (int id in listaIds)
                {
                    if (ExisteConcorrente(id, out obj))
                    {
                        list.Add(obj);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de concorrentes!", e);
            }
            return list;
        }

        public bool OrdenarLista() //ordena a lista por ordem descendente de total pontos
        {
            List<Eurovisao> list = new List<Eurovisao>();
            list = list.OrderByDescending(concorrente => concorrente.TotalPontos).ToList();
            return true;
        }
        public Eurovisao Vencedor() //diz o vencedor da eurovisão após lista ordenada por ordem descendente de total pontos
        {
            OrdenarLista();
            List<Eurovisao> list = new List<Eurovisao>();
            return list.FirstOrDefault();
        }
    }
}