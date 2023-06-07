using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.View;
using Task03MVC.MVC.Controller;

namespace Task03MVC.MVC.Model
{
    internal class JarModel //Model/Modelo
    {
        //Propriedades
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        //Método
        public JarModel ObterDetalhes(int details)
        {
            return new JarModel { Name = "Alex", BirthDate = DateOnly.Parse("01/01/2000"), Nationality = "Português", Gender = "Masculino" };
        }
    }
}
