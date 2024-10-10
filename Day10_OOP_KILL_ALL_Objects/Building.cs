using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_OOP_KILL_ALL_Objects
{
    public class Building: IDamage
    {
        //Properties
        public int Damage { get; set; }
        public int Height { get; set; }

        public Building() //Constructor, to set values to proeprties
        {
            Damage = 50;
        }
        public void TakeDamage()
        {
            Console.Write($"Building took");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {Damage} damage");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
