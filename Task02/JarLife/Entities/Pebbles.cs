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
        public Pebbles() { }
        public Pebbles(string car, string job, int home)
        {
            Car = car;
            Job = job;
            Home = home;
        }
        public Pebbles(string name, DateOnly birthDate, string nationality, string gender, string car, string job, int home) : base(name, birthDate, nationality, gender)
        {
            Car = car;
            Job = job;
            Home = home;
        }
        //Métodos
        public override void Detalhes()
        {
            Console.WriteLine($"O {Name} tem um carro da marca {Car}, o seu trabalho é {Job} e tem {Home} casa.");
        }
    }
}
