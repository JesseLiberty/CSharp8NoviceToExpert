using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Cat : Animal
   {
      public override string Speak()
      {
         return $"{base.Speak()} Meow";
      }

      public void Purr()
      {
         Console.WriteLine("purr purr");
      }

      public override void Eat()
      {
         Console.WriteLine("Cat eating");
      }

   }
}
