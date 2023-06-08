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
            _view.EscreverDetalhesMedico(medico.Funcao, medico.ID, medico.Nome, medico.Genero, medico.Localidade, medico.DataNasc, medico.CartaConducao, medico.Vencimento, medico.CC, medico.NIF, medico.Telemovel, medico.Email, medico.NomeUtil, medico.Password);
        }
        /*
        public void Login(int details) //se usar este método o login vai ser sempre aceite, por isso usar o método que aparece em baixo.
        {
            MedicoModel medico = _model.ObterDetalhes(details);

            if (medico.NomeUtil == "Med22" && medico.Password == "******")
            { _view.MensagemLoginAceite(medico.Nome); }
            else
            { _view.MensagemLoginErrado(medico.Nome); }
        }
        */
        public bool Login(int details) //alterado em relação ao projeto, para incluir aqui os console.readline.
        {
            Console.Write("Nome de Utilizador: ");
            string nomeUtil = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            MedicoModel medico = _model.ObterDetalhes(details);

            if (medico != null && medico.Password == password)
            {
                _view.MensagemLoginAceite(medico.Nome); //se o login for aceite, vai aparecer a mensagem escrita em Medico.View no método MensagemLoginAceite.
                return true;
            }
            else
            {
                _view.MensagemLoginErrado(medico.Nome); //se o login for errado, vai aparecer a mensagem escrita em Medico.View no método MensagemLoginErrado.
                return false;
 
            }
        }
        public void Logout(int details)
            {
                MedicoModel medico = _model.ObterDetalhes(details);
                _view.MensagemLogout(medico.Nome); //ir ao MedicoView e ver a mensagem que vai aparecer no ecrã, quando chamarmos este método no program.
            }
        /*
        public void SetPassword(int details)
        {
            Console.Write("Quer alterar a sua password (S/N)? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 'S' || resp == 's')
            {
                MedicoModel medico = _model.ObterDetalhes(details);

                Console.Write("Nova Password: ");
                string novaPassword = Console.ReadLine();

                medico.Password = novaPassword;
                Console.WriteLine("Password alterada.");
            }
        }
        */
        
    }
}
