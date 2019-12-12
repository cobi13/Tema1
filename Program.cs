using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int nr = rng.Next(0, 100);
            Console.WriteLine("Enter your guess:");
            string str = Console.ReadLine();
            int a = int.Parse(str);

            do
            {
                if (a < nr)
                {
                    Console.WriteLine("The number is too small!");
                    Console.WriteLine("Enter another guess:");
                    str = Console.ReadLine();
                    a = int.Parse(str);
                }

                else if (a > nr)
                {
                    Console.WriteLine("The number is too big!");
                    Console.WriteLine("Enter another guess:");
                    str = Console.ReadLine();
                    a = int.Parse(str);
                }
            }
            while (a != nr);

            Console.WriteLine("You guessed corectly! The number was: {0}", nr);

            Console.ReadKey();
        }
    }
}
