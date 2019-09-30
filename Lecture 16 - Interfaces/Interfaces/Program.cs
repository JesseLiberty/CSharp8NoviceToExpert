using System;
using System.Collections.Generic;

namespace Interfaces
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   public class Runner
   {
      public void Run()
      {
         var book = new Book();
         var newspaper = new Newspaper();
         book.Name = "Ulysses";
         book.ISBN = "1234";
         book.Write();

         newspaper.Name = "NY Times";
         newspaper.Headline = "Programmer Learns C#!!";
         newspaper.Write();

         var myList = new List<IWriteable>();
         myList.Add(book);
         myList.Add(newspaper);

         foreach (IWriteable writeable in myList)
         {
            Console.WriteLine($"The name of this writeable is {writeable.Name}");
            writeable.Write();
         }
      }
   }

   public class Book : IWriteable
   {
      public string Name { get; set; }
      public string ISBN { get; set; }

      public void Write()
      {
         Console.WriteLine("Writing my book...");
      }
   }

   public class Newspaper : IWriteable
   {
      public string Headline { get; set; }
      public string Name { get; set; }

      public void Write()
      {
         Console.WriteLine("Writing my newspaper");
      }
   }

   public interface IWriteable
   {
      string Name { get; set; }
      void Write();
   }
}
