using Microsoft.CodeAnalysis;
using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Functions
{
    class Program { 

       // use a local variable outside function scope
        static void DoubleIt(int x, out int solution) {
            solution = x * 2;
        }  

        // pass primitive variables via their reference
        public static void Swap(ref int num3,ref int num4) {
            int temp = num4;
            num4 = num3;
            num3 = temp;
        }

        // if count of parameters is unknown
        static double GetSumMore(params double[] nums)
        {
             double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void ShowInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in a zipCode {1}",name,zipCode);
        }
    
        static void Main(string[] args)
        {
            
            DoubleIt(15, out int solution);
            
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num2 : {1}",num3,num4);
            Swap(ref num3,ref num4);
            Console.WriteLine("After Swap num1 : {0} num2 : {1}", num3, num4);

            Console.WriteLine(GetSumMore(1, 3, 4, 3));

            // named parameters
            ShowInfo(zipCode: 2100, name: "Petro");

        }

    }
}
