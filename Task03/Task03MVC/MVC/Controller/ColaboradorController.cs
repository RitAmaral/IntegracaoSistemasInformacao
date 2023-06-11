using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.View;

namespace Task03MVC.MVC.Controller
{
    internal class ColaboradorController //Controller/Controlador
    {
        private ColaboradorModel _model;
        private ColaboradorView _view;
        private List<ColaboradorModel> colaboradores = new List<ColaboradorModel>(); //criação da lista de colaboradores

        public ColaboradorController(ColaboradorModel model, ColaboradorView view)
        {
            _model = model;
            _view = view;
        }

        public void MostrarDetalhesColab(int detailsColab) //mostrar detalhes do colaborador onde escrevi os detalhes no método ObterDetalhesColab na classe ColaboradorModel
        {
            ColaboradorModel colaborador = _model.ObterDetalhesColab(detailsColab);
            _view.EscreverDetalhesColab(colaborador.Funcao, colaborador.ID, colaborador.Nome, colaborador.Genero, colaborador.Localidade, colaborador.DataNasc, colaborador.CartaConducao, colaborador.Vencimento, colaborador.CC, colaborador.NIF, colaborador.Telemovel, colaborador.Email);
        }
        public void MostrarColaborador(int num) //mostrar detalhes dos colaboradores adicionados por lista no programa.
        {
            if (num >= 0 && num < colaboradores.Count)
            {
                ColaboradorModel colaborador = colaboradores[num];
                _view.MostrarColaborador(colaborador.Funcao, colaborador.ID, colaborador.Nome, colaborador.Genero, colaborador.Localidade, colaborador.DataNasc, colaborador.CartaConducao, colaborador.Vencimento, colaborador.CC, colaborador.NIF, colaborador.Telemovel, colaborador.Email);
            }
        }
        //Adicionar colaborador na lista:
        public void AddColaborador(string func, int id, string nome, string genero, string localidade, DateOnly datanasc, bool cartaconducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            ColaboradorModel colaborador = new ColaboradorModel(func, id, nome, genero, localidade, datanasc, cartaconducao, vencimento, cc, nif, telemovel, email);
            colaboradores.Add(colaborador);
        }
        //Remove colaborador da lista:
        public void RemoveColaborador(int num)
        {
            if (num >= 0 && num < colaboradores.Count)
            {
                colaboradores.RemoveAt(num);
            }
        }

    }
}
