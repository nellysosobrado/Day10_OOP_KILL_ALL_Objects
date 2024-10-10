using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_OOP_KILL_ALL_Objects
{
    public class TreasureChest: IDamage
    {
        //Properties
        public int Damage { get; set; }
        public int Value { get; set; }

        public TreasureChest()//Constructor to set propertie values
        {
            Damage = 20;
        }
        public void TakeDamage()
        {
            Console.Write($"Treasurechest took");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {Damage} damage");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
