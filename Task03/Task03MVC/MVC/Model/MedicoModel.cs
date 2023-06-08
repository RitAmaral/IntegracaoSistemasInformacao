using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.View;
using Task03MVC.MVC.Controller;
using System.Security.Cryptography.X509Certificates;

namespace Task03MVC.MVC.Model
{
    internal class MedicoModel : ColaboradorModel //Model/Modelo; MedicoModel herda de ColaboradorModel
    {
        //Propriedades
        /* 
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
        */ //estas propriedades são herdadas da classe ColaboradorModel, por isso não precisam de estar aqui, e estão comentadas.
        public string NomeUtil { get; set; }
        //private string _password { get; set; } //estou a ter erros quando a password está private, por isso mudei para public.
        public string Password { get; set; }

        //Método
        public MedicoModel ObterDetalhes(int details)
        {
            return new MedicoModel
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
                NomeUtil = "Med22",
                //_password = "******"
                Password = "******"
            };
        }

    }
}
