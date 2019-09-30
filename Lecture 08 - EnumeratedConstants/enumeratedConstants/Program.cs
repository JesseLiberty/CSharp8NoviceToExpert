using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeratedConstants
{

    enum Party
    {
        Democrat,
        Republican,
        Progressive,
        Libertarian
    }

    class Program
    {
        static void Main(string[] args)
        {

            var choice = Party.Democrat;

            switch (choice)
            {
                case Party.Democrat:
                    Console.WriteLine("You voted for a democrat");
                    break;
                case Party.Republican:
                    Console.WriteLine("You voted for a republican");
                    break;
                case Party.Progressive:
                    Console.WriteLine("You voted for a progressive");
                    break;
                case Party.Libertarian:
                    Console.WriteLine("You voted for a libertarian");
                    break;
                default:
                    Console.WriteLine("We can't tell how you voted");
                    break;
            }


        }
    }
}
