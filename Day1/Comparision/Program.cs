using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Arithmetic operators
            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            //comparision
            Console.WriteLine("enter two numbers");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("greater than " + (num3 > num4));
            Console.WriteLine("less than" +(num3 < num4));
            Console.WriteLine("equal to " +(num3 == num4));
            Console.WriteLine("less than equal" +(num3 <= num4));
            Console.WriteLine("greater than equal" +(num3 >= num4));
            Console.WriteLine("not equal" +(num3 != num4));





        }
    }
}
