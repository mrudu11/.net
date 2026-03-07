using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            string[] cars = { "Volvo", "BMW", "Ford" };         // array
            foreach (string ch in cars)                          //for foreach loop 
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine(cars[1]);         //acceassing array element

            cars[0] = "opel";                   //to change specific value by index
            Console.WriteLine(cars[0]);

            Console.WriteLine(cars.Length);     //array length

            Array.Sort(cars);               //sort cars
            foreach(string ch in cars)
            {
                Console.WriteLine(ch);  
            }

            int [,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };     //2d array declaration
            Console.WriteLine(numbers[0, 2]);                   //accessing array element
            numbers[1, 2] = 7;                                     //changing value using index
            Console.WriteLine(numbers[1,2]);

            for (int k = 0; k < numbers.GetLength(0); k++)      //loop for row 
            {
                for (int j = 0; j < numbers.GetLength(1); j++)      //loop for column
                {
                    Console.WriteLine(numbers[k, j]);
                }
            }
        }
    }
}
