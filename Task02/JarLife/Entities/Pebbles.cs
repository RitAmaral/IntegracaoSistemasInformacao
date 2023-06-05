using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarLife.Entities
{
    internal class Pebbles : Jar //golf balls herda da classe Jar
    {
        //Propriedades
        public string Car { get; set; }
        public string Job { get; set; }
        public int Home { get; set; }

        //Construtores
        public Pebbles(string car, string job, int home)
        {
            Car = car;
            Job = job;
            Home = home;
        }
        //Métodos
        public override void Detalhes()
        {
            Console.WriteLine($"Tenho um carro da marca {Car}, o meu trabalho é {Job} e tenho {Home} casa.");
        }
    }
}
