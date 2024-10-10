using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_OOP_KILL_ALL_Objects
{
    public class Goblin : IDamage
    {
        //Public propreties
        public int Damage { get; set; }
        public int HP { get; set; }

        public Goblin() //Constructor, to set values to properties
        {
            Damage = 100;
        }

        public void TakeDamage()
        {
            
            Console.Write($"Golin took");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {Damage} damage");
            Console.ResetColor();
            Console.WriteLine();
        }

    }
}
