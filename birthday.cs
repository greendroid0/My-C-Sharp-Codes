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
		    DateTime birthday;

            today = Date.Time.Now;

            System.Console.WriteLine("Please import your birthday");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Youwere born in" + birthday.ToSHortDateString());
        }
	}
}