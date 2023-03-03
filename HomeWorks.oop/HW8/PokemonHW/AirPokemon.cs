using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PokemonHW
{
    public class AirPokemon : Pokemon
    {
        public AirPokemon() : base()
        {
        }

        public AirPokemon(string id, string name) : base(id, name)
        {
        }

        public int StormPower { get; set; } = 25;

        public void StormAttackHit(Pokemon defenser)
        {

            if (Alive && defenser.Alive)
            {
                if (StormPower > 5)
                {
                    defenser.LifePower -= 10;
                    StormPower -= 5;
                    LifePower -= 2;
                    defenser.CheckAlive();
                }
                else
                {
                    Console.WriteLine("unable to do StormAttackHit any more");
                }
            }
            else
            {
                Console.WriteLine($"{Name} cant fight anymore");
            }
        }
    }
}
