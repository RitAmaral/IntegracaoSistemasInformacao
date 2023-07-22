using Anotacao_BOpg;
using Anotacoes_Constantes;
using Npgsql;
using System.Data;



namespace Anotacao_DALpg
{
    public class AnotacoesAula_DAO
    {

        private NpgsqlConnection _conn;
        /// <summary>
        ///
        /// </summary>
        public AnotacoesAula_DAO(NpgsqlConnection _conn)
        {
            this._conn = _conn;
        }
        /// <summary>
        ///
        /// </summary>
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
        public bool AdicionarAnotacao(AnotacoesAula anotacao)
        {
            if (ReferenceEquals(anotacao, null)) return false; //se enviar objeto nulo não vale a pena tar a perder tempo, logo return false
            // ATENÇÃO: não deve incluir o ID na expressão SQL porque será gerado automaticamente...

            string sqltxt = "INSERT INTO public.anotacoes (nome, aula, tipo, revisado) VALUES (@nome, @aula, @tipo, @revisado);";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@nome", anotacao.Nome);
                com1.Parameters.AddWithValue("@aula", anotacao.Aula);              
                com1.Parameters.AddWithValue("@tipo", (int)anotacao.Tipo);
                com1.Parameters.AddWithValue("@revisado", anotacao.Revisado);
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
                throw new Exception("Erro ao adicionar anotação!", e);
            }
        }

        public bool ModificarAnotacao(int id, AnotacoesAula anotacao) //modifica id da anotação
        {
            if (ReferenceEquals(anotacao, null)) return false;
            string sqltxt = "UPDATE public.anotacoes SET nome=@nome, aula=@aula, tipo=@tipo, revisado=@revisado WHERE id=@id;";
            NpgsqlTransaction? tr = null;
            try
            {
                DbOpen();
                tr = Db.BeginTransaction();
                NpgsqlCommand com1 = new NpgsqlCommand(sqltxt, Db);
                com1.Parameters.AddWithValue("@id", anotacao.Id);
                com1.Parameters.AddWithValue("@nome", anotacao.Nome);
                com1.Parameters.AddWithValue("@aula", anotacao.Aula);
                com1.Parameters.AddWithValue("@tipo", (int)anotacao.Tipo);
                com1.Parameters.AddWithValue("@revisado", anotacao.Revisado);
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
                throw new Exception("Erro ao modificar anotação!", e);
            }
        }


        public bool ApagarAnotacao(string nome) //apagar pelo nome
        {
            AnotacoesAula? obj = null;
            string tNome = nome.Trim();

            int contador = 0;
            while (ExisteAnotacao(tNome, out obj))
            {
                if (ApagarAnotacao(obj.Id))
                {
                    contador++;
                }
                else
                {
                    // não conseguiu apagar, deve-se interromper para evitar loop infinito...
                    break;
                }
            }
            return contador > 0;
        }


        public bool ApagarAnotacao(int id) //apagar pelo id
        {
            string sqltxt = "DELETE FROM public.anotacoes WHERE id=@id;";
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
                throw new Exception("Erro ao apagar anotação!", e);
            }
        }

        public bool ExisteAnotacao(string nome) //existe anotação pelo nome
        {
            AnotacoesAula? obj = null;
            return ExisteAnotacao(nome, out obj);
        }

        public bool ExisteAnotacao(string nome, out AnotacoesAula? obj) //acrescentar
        {
            obj = null;
            string tNome = nome.Trim();
            string sqltxt = "SELECT id FROM public.anotacoes WHERE nome=@nome;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                qry1.Parameters.AddWithValue("@nome", tNome);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows && res1.Read())
                {
                    int id = res1.GetInt32(res1.GetOrdinal("id"));
                    res1.Close();
                    return ExisteAnotacao(id, out obj);
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter anotação por nome!", e);
            }
            return false;
        }

        public bool ExisteAnotacao(int id, out AnotacoesAula? obj) //existe anotação pelo id
        {
            bool resultado = false;
            obj = null;
            string sqltxt = "SELECT id, nome, aula, tipo, revisado FROM public.anotacoes WHERE id=@id;";

            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                qry1.Parameters.AddWithValue("@id", id);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows && res1.Read())
                {
                    string tmpNome = res1["nome"].ToString();
                    string tmpAula = res1["aula"].ToString();
                    Tipo tmpTipo = (Tipo)res1.GetByte(res1.GetOrdinal("tipo"));
                    bool tmpRevisado = res1.GetBoolean(res1.GetOrdinal("revisado"));
                    res1.Close();
                    obj = new AnotacoesAula(id, tmpNome, tmpAula, tmpTipo, tmpRevisado);
                    resultado = true;
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter anotacao por id!", e);
            }
            return resultado;
        }

        public List<string> GetAnotacoesList()
        {
            List<string> list = new List<string>();
            string sqltxt = "SELECT id, nome, aula, tipo, revisado FROM public.anotacoes;";
            try
            {
                DbOpen();
                NpgsqlCommand qry1 = new NpgsqlCommand(sqltxt, Db);
                NpgsqlDataReader res1 = qry1.ExecuteReader();
                if (res1.HasRows)
                {
                    while (res1.Read())
                    {
                        int tmpId = res1.GetInt32(res1.GetOrdinal("id"));
                        string tmpNome = res1["nome"].ToString();
                        string tmpAula = res1["aula"].ToString();
                        Tipo tmpTipo = (Tipo)res1.GetByte(res1.GetOrdinal("tipo"));
                        bool tmpRevisado = res1.GetBoolean(res1.GetOrdinal("revisado"));
                        list.Add($"{tmpId}, {tmpNome} |\t{tmpAula} |\t{tmpTipo} |\t{tmpRevisado}");
                    }
                }
                if (!res1.IsClosed) res1.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de anotações!", e);
            }
            return list;
        }


        //serviços para o API
        public List<AnotacoesAula> GetAnotacoes()
        {
            List<AnotacoesAula> list = new List<AnotacoesAula>();
            string sqltxt = "SELECT id, nome, aula FROM public.anotacoes;";

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
                        int tmpId = res1.GetInt32(res1.GetOrdinal("id"));
                        listaIds.Add(tmpId);
                    }
                }
                if (!res1.IsClosed) res1.Close();
                // passo 2
                // obter objetos e criar a lista
                AnotacoesAula? obj;
                foreach (int id in listaIds)
                {
                    if (ExisteAnotacao(id, out obj))
                    {
                        list.Add(obj);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter lista<string> de anotações!", e);
            }
            return list;
        }
    }
}