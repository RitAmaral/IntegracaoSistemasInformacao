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
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }

        //Métodos
        public abstract void Detalhes();

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Estas são as características da vida de uma Pessoa: {Detalhes}.");
        }
    }
}
