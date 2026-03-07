using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        { int num1 = 20;
          int num2 = 20;
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater ", num1);
            }
            else if(num1 ==num2)
            {
                Console.WriteLine("num1 and num2 are equal");
            }
            else
            {
                Console.WriteLine("num2 is greater ", num2);
            }


            int time = 20;                      //Short Hand If...Else
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
