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
			double celsius;
			Console.Write("Enter Fahrenheit temperature : ");
			double fahrenheit = Convert.ToDouble(Console.ReadLine());
			celsius = (fahrenheit - 32) * 5 / 9;
			Console.WriteLine("The converted Celsius temperature is : " + celsius);
			Console.ReadLine();
		}
	}
}
