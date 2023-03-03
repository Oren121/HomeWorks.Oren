using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorks.oop.HW8.PokemonHW
{
    public class Pokemon
    {
        public Pokemon(string id, string name)
        {
            Id = id;
            Name = name;

        }

        public Pokemon()
        {
            Id = "IDless";
            Name = "Nameless";
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int LifePower { get; set; } = 100;
        public int AmmunitionPower { get; set; } = 50;
        public bool Alive { get; set; } = true;

        public void Attack(Pokemon defenser, int ammunitionPower)
        {
            if (Alive && defenser.Alive)
            {
                if (AmmunitionPower >= ammunitionPower)
                {
                    defenser.LifePower -= ammunitionPower / 2;
                    AmmunitionPower -= ammunitionPower;
                    defenser.CheckAlive();
                }
                else
                {
                    Console.WriteLine("Not enough Ammunition");
                }
            }
            else
            {
                Console.WriteLine($"{Name} cant fight anymore");
            }
        }
        public bool CheckAlive()
        {
            if (LifePower <= 0)
            {
                LifePower = 0;
                Console.WriteLine($"{Name} HP fell below 0");
                Alive = false;
                return false;
            }
            else return true;
        }
    }
}
