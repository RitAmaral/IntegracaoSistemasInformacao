using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarLife.Entities
{
    internal class Sand : Jar //golf balls herda da classe Jar
    {
        //Propriedades
        public string Procrastinate { get; set; }
        public string Quarrels { get; set; }

        //Construtores
        public Sand() { }
        public Sand(string procrastinate, string quarrels)
        {
            Procrastinate = procrastinate;
            Quarrels = quarrels;
        }
        public Sand(string name, DateOnly birthDate, string nationality, string gender, string procrastinate, string quarrels) :base(name, birthDate, nationality, gender)
        {
            Procrastinate = procrastinate;
            Quarrels = quarrels;
        }
        //Métodos
        public override void Detalhes()
        {
            Console.WriteLine($"Procrastinar? O {Name}? {Procrastinate} .. mas não ocupa muito do seu tempo com isso. Perder tempo com brigas sem importância? {Quarrels}.");
        }
    }
}
