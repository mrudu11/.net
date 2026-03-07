using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        class Car
        {
            //class members
            string color = "red";  //fields 
            int num = 3531;         //fields
            public void name()          //methods
            {
                Console.WriteLine("Thar");
            }
            string model;
            public Car()
            {
                model = "Mustang";
            }

            static void Main(string[] args)
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.color);
                Console.WriteLine(myObj.num);
                myObj.name();
                Console.WriteLine(myObj.model);

            }
        }

    }
}
