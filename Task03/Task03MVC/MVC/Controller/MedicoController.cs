using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.View;

namespace Task03MVC.MVC.Controller
{
    internal class MedicoController //Controller/Controlador
    {
        //Propriedades
        private MedicoModel _model;
        private MedicoView _view;
        //Construtor
        public MedicoController(MedicoModel model, MedicoView view)
        {
            _model = model;
            _view = view;
        }
        //Métodos
        public void MostrarDetalhes(int details) //quando chamarmos este método no programa, vamos ver os detalhes que aparecem na view do médico no método escreverdetalhesmedico.
        {
            MedicoModel medico = _model.ObterDetalhes(details);
            _view.EscreverDetalhesMedico(medico.ID, medico.Nome, medico.Genero, medico.Localidade, medico.DataNasc, medico.CartaConducao, medico.Vencimento, medico.CC, medico.NIF, medico.Telemovel, medico.Email, medico.NomeUtil, medico.Password);
        }

        public void Login(int details)
        {
            MedicoModel medico = _model.ObterDetalhes(details);

            if (medico.NomeUtil == "Med22" && medico.Password == "******")
            { _view.MensagemLoginAceite(medico.Nome); }
            else
            { _view.MensagemLoginErrado(medico.Nome); }
        }
        public void Logout(int details)
            {
                MedicoModel medico = _model.ObterDetalhes(details);
                _view.MensagemLogout(medico.Nome); //ir ao MedicoView e ver a mensagem que vai aparecer no ecrã, quando chamarmos este método no program.
            }

        /*
        public void SetPassword(int details)
        {
            MedicoModel medico = _model.ObterDetalhes(details);
            if (medico.Password != null && medico.Password.Length > 5)
            {
                medico.Password = medico.Password;
            }
            else { Console.WriteLine("Escreva uma password com mais de 5 caracteres."); }
        }
        */
        
    }
}
