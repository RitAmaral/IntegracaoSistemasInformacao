using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03MVC.MVC.View
{
    internal class ColaboradorView //View/Visualizador
    {
        //Métodos
        public void EscreverDetalhesColab(string funcao, int id, string nome, string genero, string localidade, DateOnly dataNasc, bool cartaConducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Console.WriteLine("Detalhes: ");
            Console.WriteLine();
            Console.WriteLine("Função: " + funcao);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Localidade: " + localidade);
            Console.WriteLine("Data de Nascimento: " + dataNasc.ToString("dd/MM/yyyy"));
            Console.WriteLine("Carta de Condução: " + cartaConducao);
            Console.WriteLine("Vencimento: " + vencimento);
            Console.WriteLine("CC: " + cc);
            Console.WriteLine("NIF: " + nif);
            Console.WriteLine("Telemóvel: " + telemovel);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("-----------------");
        }

        public void MostrarColaborador(string funcao, int id, string nome, string genero, string localidade, DateOnly dataNasc, bool cartaConducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Console.WriteLine(
                "Detalhes do Colaborador: "
                + "\n"
                + "Função: " + funcao
                + "\n"
                + "ID: " + id
                + "\n"
                + "Nome: " + nome
                + "\n"
                + "Género: " + genero
                + "\n"
                + "Localidade: " + localidade
                + "\n"
                + "Data de Nascimento: " + dataNasc.ToString("dd/MM/yyyy")
                + "\n"
                + "Carta de Condução: " + cartaConducao
                + "\n"
                + "Vencimento: " + vencimento
                + "\n"
                + "CC: " + cc
                + "\n"
                + "NIF: " + nif
                + "\n"
                + "Telemóvel: " + telemovel
                + "\n"
                + "Email: " + email
                + "\n"
                + "-----------------------");
        }

    }
}
