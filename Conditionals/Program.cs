using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 4;
            
            
            // traditional if
            if ((age >= 6 && age <=9 ))
            {
                Console.WriteLine("Go to elementary school");
            }

            if ((age >= 10 && age <= 14))
            {
                Console.WriteLine("Go to middle school");
            }

            if ((age > 15 && age <= 19))
            {
                Console.WriteLine("Go to high school");
            }

            bool canDrive = age > 16 ? true : false;

            // switch case
            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine(
                        "Go to Dayly Care"
                        );
                    break;

            }

            string name1 = "Derek";
            string name2 = "Derek";

            if(name1.Equals(name2,StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }
        }
    }
}