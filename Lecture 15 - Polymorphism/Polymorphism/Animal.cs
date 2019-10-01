using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public abstract class Animal
   {
      public virtual string Speak()
      {
         return "The animal is speaking";
      }

      public abstract void Eat();

   }
}
