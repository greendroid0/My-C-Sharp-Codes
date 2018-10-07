using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
	class Game
	{
        public static double num1, num2, res;
		static void Main(string[] args)			
        {
			Console.WriteLine("Please write first number.");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please write second number.");
            num2 = Convert.ToDouble(Console.ReadLine());
            Sum();
            Substraction();
            Multiple();
            Divide();
		}
        static void Sum ()
        {
            res = num1 + num2;
            Console.WriteLine("Sum is:" + res);
        }
        static void Substraction ()
        {
            res = num1 - num2;
            Console.WriteLine("Substraction is:" + res);
        }
         static void Multiple ()
        {
            res = num1 * num2;
            Console.WriteLine("Multiple is:" + res);
        }
         static void Divide ()
        {
            res = num1 / num2;
            Console.WriteLine("Divide is:" + res);
        }
	}
}