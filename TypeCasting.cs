using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt;       

            Console.WriteLine(myInt);      //int to double automatically type casting 
            Console.WriteLine(myDouble);

            double myDecimal = 9.78;           //decimal to int mannually type casting 
            int myInt2 = (int)myDecimal;

            Console.WriteLine(myDecimal);
            Console.WriteLine(myInt2);

            int myInt3 = 10;
            double myDouble1 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble1));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));    


          



        }
    }
}
