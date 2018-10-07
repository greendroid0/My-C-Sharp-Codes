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
			int midterm;
			int final;
			double result;
				Console.WriteLine("Please write your midterm result");
				    midterm = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please write your final result");
				    final = Convert.ToInt32(Console.ReadLine());
				    result = (midterm * 0.4 + final * 0.6);
				    Console.WriteLine("Result is:" + result);

				
		}
	}
}