using System;
using System.Threading.Tasks;

namespace Lab8
{

public class Program 
{
 public static void Main (string[] args) 
  {
    Start:

      Console.WriteLine ("Input slot number, block letter and is it lit or not (sloth number,block letter,true or false): ");
      string input = Console.ReadLine();

      int firstCommaLocation = input.IndexOf(',');
      int secondCommaLocation = input.IndexOf(',') + 2;
  
      int slotnum = Convert.ToInt32(input.Substring(0, firstCommaLocation));
      char blockletter = Convert.ToChar(input.Substring(firstCommaLocation + 1,1));
      bool trueRnot = Convert.ToBoolean(input.Substring(secondCommaLocation + 1));

      string litornot = "";
      if (trueRnot == true)
      {
        litornot = "True";
      }
      else
      {
        litornot = "False";
      }

      Console.Clear();

      Console.WriteLine("Slot Number :\n " + slotnum + "Block Letter :\n " + blockletter + "Lit or Not :\n" + litornot);

      Console.ReadLine();

      goto Start;
    }
  }
}
