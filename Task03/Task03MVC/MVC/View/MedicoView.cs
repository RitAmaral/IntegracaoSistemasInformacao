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
        public void EscreverDetalhesMedico(string funcao, int id, string nome, string genero, string localidade, DateOnly dataNasc, bool cartaConducao, double vencimento, int cc, int nif, int telemovel, string email, string nomeUtil, string password)
        {
            Console.WriteLine("Detalhes: ");
            Console.WriteLine();
            Console.WriteLine("Função: " + funcao);
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
            Console.WriteLine($"Login Aceite! Bem-vindo {nome}!"); //mensagem que vai aparecer se o login for aceite.
            Console.WriteLine();
        }
        public void MensagemLoginErrado(string nome)
        {
            Console.WriteLine($"Login Errado! Tenta novamente, {nome}!"); //mensagem que vai aparecer se o login for errado.
        }
        public void MensagemGetPassword(string nome, string password)
        {
            Console.WriteLine($"{nome} a tua password é: {password}"); 
            Console.WriteLine();
        }
        public void MensagemSetPassword(string password)
        {
            Console.WriteLine($"Password alterada para: {password}");
        }
        public void MensagemLogout(string nome)
        {
            Console.WriteLine($"Até breve {nome}! \n--------------- \nSessão terminada."); //mensagem que vai ser feita quando fizer logout.
        }

    }
}
