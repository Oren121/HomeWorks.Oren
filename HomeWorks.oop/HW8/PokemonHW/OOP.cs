using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PokemonHW
{
    public class PokemonOOP
    {
        public static void Run()
        {
            WaterPokemon w1 = new WaterPokemon("123", "Water");
            AirPokemon a1 = new AirPokemon("321", "Air");
            while (w1.Alive && a1.Alive)
            {
                w1.Attack(a1, 3);
                a1.Attack(a1, 7);
                w1.ElectricAttackHit(a1);
                a1.StormAttackHit(w1);
            }

        }
    }
}
