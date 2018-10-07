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
		    DateTime today;

            today = Date.Time.Now;

            System.Console.WriteLine(today);
            System.Console.WriteLine(today.ToShortDateString());
            System.Console.WriteLine(today.ToShortTimeString);
        }
	}
}