using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.Controller;
using System.Reflection;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace Task03MVC.MVC.View
{
    internal class MedicoView //View/Visualizador
    {
        //Método
        public void EscreverDetalhesMedico(int id, string nome, string genero, string localidade, DateOnly dataNasc, bool cartaConducao, double vencimento, int cc, int nif, int telemovel, string email, string nomeUtil, string password)
        {
            Console.WriteLine("Detalhes do Médico: ");
            Console.WriteLine();
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Localidade: " + localidade);
            Console.WriteLine("Data de Nascimento: " +  dataNasc.ToString("dd/MM/yyyy"));
            Console.WriteLine("Carta de Condução: " + cartaConducao);
            Console.WriteLine("Vencimento: " + vencimento);
            Console.WriteLine("CC: " + cc);
            Console.WriteLine("NIF: " + nif);
            Console.WriteLine("Telemóvel: " + telemovel);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Nome de Utilizador: " + nomeUtil);
            Console.WriteLine("Password: " + password);
        }
        public void MensagemLoginAceite(string nome)
        {
            Console.WriteLine($"Login Aceite! Bem-vindo {nome}!");
        }
        public void MensagemLoginErrado(string nome)
        {
            Console.WriteLine($"Login Errado! Tenta novamente, {nome}!");
        }
        public void MensagemLogout(string nome)
        {
            Console.WriteLine($"Até breve {nome}! \n--------------- \nSessão terminada.");
        }

    }
}
