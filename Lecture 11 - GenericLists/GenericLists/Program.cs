using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
   class Program
   {
      static void Main(string[] args)
      {


         var listOfStrings = new List<string>() { "Hello", "World", "Udemy", "Jesse", "Rodrigo" };
         for (int i = 0; i < 5; i++)
         {
            Console.WriteLine($"The value of i: {i}. The value of listOfStrings[{i}]: {listOfStrings[i]}");
         }
      }
   }
}
