using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Runner
   {
      public void Run()
      {
         //var fluf = new Cat();
         //Console.WriteLine($"{fluf.Speak()}");
         //fluf.Purr();
         //fluf.Eat();

         //var spot = new Dog();
         //Console.WriteLine($"{spot.Speak()}");
         //spot.Breed = "Chihuahua";
         //spot.TellBreed();
         //spot.Eat();

         var fred = new Cat();
         var milo = new Dog();
         var sappho = new Cat();
         var charlie = new Dog();
         var bilbo = new Elephant();

         var zoo = new List<Animal>();
         zoo.Add(fred);
         zoo.Add(milo);
         zoo.Add(sappho);
         zoo.Add(charlie);
         zoo.Add(bilbo);

         foreach(var animal in zoo)
         {
            animal.Eat();
            Console.WriteLine(animal.Speak());
         }

      }
   }
}
