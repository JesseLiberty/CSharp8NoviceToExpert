using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         // var peppy = new Dog(5, 14);
         var peppy = new Dog();
         peppy.Pet(5);
         bool healthy = peppy.IsMyDogHealthy();
         Console.WriteLine($"Is Peppy healthy? {healthy}");
      }


   }
}
