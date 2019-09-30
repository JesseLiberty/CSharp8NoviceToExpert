using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge;
            int yourAge = 30;
            var hisAge = 50;

            double mySalary = 400.57;
            var yourSalary = 600.29;

            //int sum1 = yourAge + mySalary;
            //double sum1 = yourAge + mySalary;
            int sum1 = yourAge + (int)mySalary;
            Console.WriteLine($"Sum1 = {sum1}");

            int intValue = (int) mySalary;
            Console.WriteLine($"intValue = {intValue}, mySalary={mySalary}");

            bool IAmMale = true;
            var YouAreFemale = true;
            var TheyAreNonBinary = true;

            Console.WriteLine($"I am male = {IAmMale}");
            Console.WriteLine($"20 is less than 30 {20 > 30}");

            var answer = hisAge < yourAge;
            Console.WriteLine($"hisAge < yourAge {answer}");

        }
    }
}
