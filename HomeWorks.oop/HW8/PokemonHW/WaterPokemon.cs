using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.oop.HW8.PokemonHW
{
    public class WaterPokemon : Pokemon
    {
        public WaterPokemon() : base()
        {
        }

        public WaterPokemon(string id, string name) : base(id, name)
        {
        }

        public int ElectricPower { get; set; } = 20;

        public void ElectricAttackHit(Pokemon defenser)
        {
            if (Alive && defenser.Alive)
            {
                if (ElectricPower > 8)
                {
                    defenser.LifePower -= 20;
                    ElectricPower -= 8;
                    LifePower -= 2;
                    defenser.CheckAlive();
                }
                else
                {
                    Console.WriteLine("unable to do ElectricAttackHit any more");
                }
            }
            else
            {
                if (!Alive)
                {
                    Console.WriteLine($"{Name} cant fight anymore");
                }
            }
        }
    }
}
