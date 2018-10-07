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
			int distance;
            int speed;
            int time;

            Console.WriteLine("Write your distance.");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your speed.");
            speed = Convert.ToInt32(Console.ReadLine());
            time = distance / speed;
            Console.WriteLine("it takes --->" + time);
        }
	}
}