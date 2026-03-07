using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter user name");               
            string UserName = Console.ReadLine();               //here no need to convert input automatically in to string
            Console.WriteLine("user name is :" + UserName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());      //here mannually need to convert int int
            Console.WriteLine("Your age is: " + age);
            
        }
    }
}
