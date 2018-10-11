using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolusage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   bool x;
               int b;

               Console.Write("Input a number: ");
               b = Convert.ToInt32(Console.ReadLine());

               x = (b > 10);
               Console.WriteLine(x);

               Console.ReadLine(); */

            bool x;
            int b;

            Console.Write("Press s play game.\n\n");
            b = Console.ReadKey().KeyChar;

            Console.Clear();

            x = (b == 's');

            Console.WriteLine("Game is loading...");
            Console.ReadLine();
        }
    }
}
