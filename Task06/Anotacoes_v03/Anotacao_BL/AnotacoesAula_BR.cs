﻿using Anotacao_BO;
using Anotacao_DAL;
using Anotacoes_Constantes;
using Anotacoes_Models2Api;

namespace Anotacao_BL
{
    public class AnotacoesAula_BR
    {
        private AnotacoesAula_DAO _AnotacoesDao;

        public AnotacoesAula_BR()
        {
            _AnotacoesDao = new AnotacoesAula_DAO();
        }

        public AnotacoesAula NovaAnotacao(string nome, string aula, Tipo tipo, bool revisado) //adicionar anotação ao colocar todos os parametros
        {
            string tNome = nome.Trim();
            if (tNome.Length == 0) throw new ArgumentNullException(nameof(tNome));
            string tAula = aula.Trim();
            if (tAula.Length == 0) throw new ArgumentNullException(nameof(tAula));
            Tipo tTipo = tipo;
            bool tRevisado = revisado;

            return new AnotacoesAula(tNome, tAula, tTipo, tRevisado);
        }

        public bool AdicionarAnotacao(AnotacoesAula anotacao) //adicionar anotacao
        {
            if (ReferenceEquals(anotacao, null)) return false;
            return _AnotacoesDao.AdicionarAnotacao(anotacao);
        }
        public List<string> GetAnotacoesList() //mostra lista
        {
            return _AnotacoesDao.GetAnotacoesList();
        }
        public bool ApagarAnotacao(string nome) //apaga anotação pelo nome
        {
            return _AnotacoesDao.ApagarAnotacao(nome);
        }
        public bool ModificarAnotacao(int id, AnotacoesAula anotacao) //modifica id de uma anotação
        {
            if (ReferenceEquals(anotacao, null)) return false;
            return _AnotacoesDao.ModificarAnotacao(id, anotacao);
        }
        public bool ExisteAnotacao(string nome) //verifica se existe anotação pelo nome
        {
            return _AnotacoesDao.ExisteAnotacao(nome);
        }
        public void ExportarDados() //exporta os dados
        {
            _AnotacoesDao.ExportarDados();
        }
        public bool ImportarDados() //importa os dados
        {
            return _AnotacoesDao.ImportarDados();
        }

        //serviços para o API
        public List<AnotRegistoResponse> GetAnotacoesListResponse()
        {
            List<AnotRegistoResponse> lista = new List<AnotRegistoResponse>();
            foreach (var c in _AnotacoesDao.GetAnotacoes()) // é preciso criar depois
            {
                lista.Add(c.RegistoAnotacaoResponse());
            }
            return lista;
        }
        public bool ExisteAnotacao(int id, out AnotacoesAula? obj)
        {
            obj = null;
            return _AnotacoesDao.ExisteAnotacao(id, out obj);
        }
        public AnotRegistoResponse? ObterAnotacaoResponse(int id)
        {
            AnotRegistoResponse? obj = null;
            AnotacoesAula? anotacao = null;
            if (ExisteAnotacao(id, out anotacao)) //se nao tiver Existe anotação por id, é preciso criar novo método
            {
                obj = new AnotRegistoResponse
                {
                    Id = anotacao.Id,
                    Nome = anotacao.Nome,
                    Aula = anotacao.Aula,
                    Tipo = anotacao.Tipo,
                    Revisado = anotacao.Revisado
                };
            }
            return obj;
        }
        public bool AdicionarAnotacaoRequest(AnotRegistoRequest request)
        {
            AnotacoesAula anotacao = NovaAnotacao(
                request.Nome,
                request.Aula,
                request.Tipo,
                request.Revisado);
            return AdicionarAnotacao(anotacao);
        }
        public bool ModificarAnotacaoRequest(int id, AnotRegistoRequest request)
        {
            AnotacoesAula? obj = null;
            if (ExisteAnotacao(id, out obj)) //mesmo que só queira alterar alguns atributos, colocar todos
            {
                obj.Nome = request.Nome;
                obj.Aula = request.Aula;
                obj.Tipo = request.Tipo;
                obj.Revisado = request.Revisado;
                return ModificarAnotacao(id, obj);
            }
            return false;
        }
        public bool ApagarAnotacao(int id) //nao precisa de request porque pode ser um método global
        {
            return _AnotacoesDao.ApagarAnotacao(id);
        }
    }
}