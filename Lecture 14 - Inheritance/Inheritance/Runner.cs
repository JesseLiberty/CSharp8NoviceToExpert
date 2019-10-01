using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Runner
   {
      public void Run()
      {
         var fluf = new Cat();
         Console.WriteLine($"{fluf.Speak()}");
         fluf.Purr();
         fluf.Eat();

         var spot = new Dog();
         Console.WriteLine($"{spot.Speak()}");
         spot.Breed = "Chihuahua";
         spot.TellBreed();
         spot.Eat();
      }
   }
}
