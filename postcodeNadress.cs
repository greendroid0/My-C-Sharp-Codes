using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)			
        {
			int postcode1, postcode2;
            string adress1, adress2;

            Console.WriteLine("Write your first postcode");
            postcode1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your first adress");
            adress1 = COnsole.ReadLine();
            Console.Clear();
            Console.WriteLine("Write your second postcode");
            postcode2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your second adress");
            adress2 = COnsole.ReadLine();
        }
	}
}