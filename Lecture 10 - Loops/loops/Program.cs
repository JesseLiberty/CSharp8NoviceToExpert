using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
   class Program
   {
      static void Main(string[] args)
      {
         //for(var i = 0; i < 20; i++)
         //{
         //   Console.WriteLine($"i = {i}");
         //}

         var value = 20;

         //while (value < 20)
         //{
         //   Console.WriteLine($"value = {value}");
         //   value++;
         //}

         do
         {
            Console.WriteLine($"value = {value}");
            value++;

         } while (value < 20);

      }
   }
}
