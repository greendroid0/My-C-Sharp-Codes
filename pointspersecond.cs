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
			int score = 1356;
            int totalSecondsPlayed = 10000;

            float pointsPerSecond = (float)score / totalSecondsPlayed;
            Console.WriteLine("Point per second is: " + pointsPerSecond);
            
        }
	}
}