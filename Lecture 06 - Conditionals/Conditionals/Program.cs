using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAge = 4;
            if (myAge > 30)
            {
                Console.WriteLine("You are old.");

            }
            else
            {
                if (myAge > 10)
                {
                    Console.WriteLine("You are not old");

                }
                else
                {
                    Console.WriteLine("You are young");
                }
            }
        }
    }
}
