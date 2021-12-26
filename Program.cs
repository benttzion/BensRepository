using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDice21._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int die1 = 0; 
            int die2 = 1;
            int attempts = 0;
            Console.WriteLine("Press to roll ");
            Random numberGen = new Random();
            while (die1 != 6 || die2 != 6)
            {
                Console.ReadLine();
                die1 = numberGen.Next(1, 7);
                die2 = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled : {die1} , {die2}");
                attempts++;
            }
            Console.WriteLine("attempts: " + attempts);
            Console.ReadLine();
        }
    }
}
