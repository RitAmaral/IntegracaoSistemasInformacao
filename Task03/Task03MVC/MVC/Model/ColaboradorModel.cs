using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Controller;

namespace Task03MVC.MVC.Model
{
    internal class ColaboradorModel //Model/Modelo; a classe Colaborador é uma superclasse, MedicoModel herda de ColaboradorModel.
    {
        //Propriedades
        public string Funcao { get; set; }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Localidade { get; set; }
        public DateOnly DataNasc { get; set; }
        public bool CartaConducao { get; set; }
        public double Vencimento { get; set; }
        public int CC { get; set; }
        public int NIF { get; set; }
        public int Telemovel { get; set; }
        public string Email { get; set; }

        //Construtores
        public ColaboradorModel()
        {
        }

        public ColaboradorModel(string funcao, int id, string nome, string genero, string localidade, DateOnly dataNasc, bool cartaConducao, double vencimento, int cc, int nif, int telemovel, string email)
        {
            Funcao = funcao;
            ID = id;
            Nome = nome;
            Genero = genero;
            Localidade = localidade;
            DataNasc = dataNasc;
            CartaConducao = cartaConducao;
            Vencimento = vencimento;
            CC = cc;
            NIF = nif;
            Telemovel = telemovel;
            Email = email;
        }

        //Métodos
        public ColaboradorModel ObterDetalhesColab(int detailsColab) //para mostrar os detalhes de um colaborador criado aqui e não no programa por lista.
        {
            return new ColaboradorModel
            {
                Funcao = "Médico",
                ID = 22,
                Nome = "Carlos Silva",
                Genero = "Masculino",
                Localidade = "Braga",
                DataNasc = DateOnly.Parse("09/03/1985"),
                CartaConducao = true,
                Vencimento = 2000,
                CC = 12815633,
                NIF = 211792762,
                Telemovel = 916124429,
                Email = "carlos@gmail.com",
            };
        }
    }
}
