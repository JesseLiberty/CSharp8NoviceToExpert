using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Dog
   {
      private double healthyWeight;
      private int age;
      private int weight;

      public Dog(int age, int wt)
      {
         this.age = age;
         weight = wt;
      }

      public Dog()
      {
         age = 3;
         weight = 20;
      }


      public void Pet()
      {
         Console.WriteLine("I love to be pet");
      }

      public void Pet(int howManyTimes)
      {
         for (var i = 0; i<howManyTimes; i++)
         {
            Console.WriteLine("I love to be pet");

         }
      }

      public bool IsMyDogHealthy()
      {
         ComputeHealthyWeight();
         if (healthyWeight < 5.0)
         {
            return true;
         }
         else
         {
            return false;
         }
      }
      private void ComputeHealthyWeight()
      {
         healthyWeight = weight / age;
      }

   }
}
