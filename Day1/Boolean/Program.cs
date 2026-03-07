using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9
            Console.WriteLine(x < y); //returns false , because 10 is highter than 9
            Console.WriteLine(x == y);  //returns false , because 10 and 9 are not equal
            Console.WriteLine(x >= y);     //check greater than equal to 
            Console.WriteLine(x <= y);       //check less than equal to
        }
    }
}
