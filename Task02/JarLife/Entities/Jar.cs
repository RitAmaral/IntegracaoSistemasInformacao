using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarLife.Entities
{
    internal abstract class Jar //Superclasse Jar, que representa a Life/Vida
    {
        //Propriedades
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }

        //Construtores
        public Jar() { }

        protected Jar(string name, DateOnly birthDate, string nationality, string gender)
        {
            Name = name;
            BirthDate = birthDate;
            Nationality = nationality;
            Gender = gender;
        }


        //Métodos
        public abstract void Detalhes();

        public void MostrarDetalhes()
        {
            Console.WriteLine($"O {Name}, do sexo {Gender}, nasceu no dia {BirthDate} e é {Nationality}.");
        }
    }
}
