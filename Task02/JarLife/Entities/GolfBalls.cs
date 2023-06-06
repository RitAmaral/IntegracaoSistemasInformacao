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
        public GolfBalls() { }
        public GolfBalls(int family, int friends, string health, string passions)
        {
            Family = family;
            Friends = friends;
            Health = health;
            Passions = passions;
        }

        public GolfBalls(string name, DateOnly birthDate, string nationality, string gender, int family, int friends, string health, string passions) :base(name, birthDate, nationality, gender)
        {
            Family = family;
            Friends = friends;
            Health = health;
            Passions = passions;
        }
        //Métodos
        public override void Detalhes()
        {
            Console.WriteLine($"O {Name}, do sexo {Gender}, nasceu no dia {BirthDate} e é {Nationality}. A família do {Name} é constituída por {Family} membros. Tem {Friends} amigos, é {Health} e tem muitos hobbies: {Passions}");
        }
    }
}
