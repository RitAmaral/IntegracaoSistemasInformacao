using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.Controller;

namespace Task03MVC.MVC.View
{
    internal class JarView //View/Visualizador
    {
        //Método
        public void EscreverDetalhesJar(string name, DateOnly birthDate, string nationality, string gender)
        {
            Console.WriteLine("Detalhes do Jar: ");
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Data de Nascimento: " +  birthDate);
            Console.WriteLine("Nacionalidade: " + nationality);
            Console.WriteLine("Género: " + gender);
        }
    }
}
