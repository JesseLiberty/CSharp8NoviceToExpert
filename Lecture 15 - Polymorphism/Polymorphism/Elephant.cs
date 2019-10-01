using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Elephant : Animal
   {
      public override string Speak()
      {
         return "Blaaaat!";
      }

      public override void Eat()
      {
         Console.WriteLine("Elephant munching");
      }
   }
}
