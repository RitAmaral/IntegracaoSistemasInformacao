using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JarLife.Entities.Exception;

namespace JarLife.Entities
{
    internal class FabricaJar
    {
        public Jar CriarJar(string elemento)
        {
            switch (elemento)
            {
                case "GolfBalls":
                    return new GolfBalls("Alex", DateOnly.Parse("01/01/2000"), "português", "masculino", 5, 5, "saudável", "futebol, cantar, etc..");
                case "Pebbles":
                    return new Pebbles("Alex", DateOnly.Parse("01/01/2000"), "Português", "Masculino", "BMW", "Software Developer", 1);
                case "Sand":
                    return new Sand("Alex", DateOnly.Parse("01/01/2000"), "Português", "Masculino", "Sim", "Não");
                default:
                    throw new JarException("Erro: Tipo de elemento inválido neste Jar. Elementos disponíveis: GolfBalls, Pebbles e Sand.");
            }
        }
    }
}
