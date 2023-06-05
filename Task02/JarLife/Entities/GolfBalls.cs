using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarLife.Entities
{
    internal class GolfBalls : Jar //golf balls herda da classe Jar
    {
        //Propriedades
        public int Family { get; set; }
        public int Friends { get; set; }
        public string Health { get; set; }
        public string Passions { get; set; }

        //Construtores
        public GolfBalls(int family, int friends, string health, string passions)
        {
            Family = family;
            Friends = friends;
            Health = health;
            Passions = passions;
        }

        //Métodos
        public override void Detalhes()
        {
            Console.WriteLine($"A minha família é constituída por {Family} membros. Tenho {Friends} amigos, sou {Health} e tenho muitos hobbies: {Passions}");
        }
    }
}
