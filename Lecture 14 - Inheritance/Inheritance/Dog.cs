using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Dog : Animal
   {
      public string Breed { get; set; }

      public override string Speak()
      {
         return $"{base.Speak()} Woof!";
      }

      public void TellBreed()
      {
         Console.WriteLine($"My breed is {Breed}");
      }

      public override void Eat()
      {
         Console.WriteLine("Dog is eating");
      }
   }
}
