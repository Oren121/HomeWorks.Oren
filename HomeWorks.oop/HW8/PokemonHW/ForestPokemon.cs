using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PokemonHW
{
    public class ForestPokemon : Pokemon
    {
        public ForestPokemon() : base()
        {
        }

        public ForestPokemon(string id, string name) : base(id, name)
        {
        }

        public int WoodsPower { get; set; } = 30;

        public void WoodsAttackHit(Pokemon defenser)
        {
            if (Alive && defenser.Alive)
            {
                if (WoodsPower > 3)
                {
                    defenser.LifePower -= 8;
                    WoodsPower -= 3;
                    LifePower -= 2;
                    defenser.CheckAlive();
                }
                else
                {
                    Console.WriteLine("unable to do WoodsAttackHit any more");
                }
            }
            else
            {
                Console.WriteLine($"{Name} cant fight anymore");

            }
        }
    }
}
