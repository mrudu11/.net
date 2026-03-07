using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_lab
{
    internal class Program
    {
        static void MyMethod()                  //without parameter
        {
            Console.WriteLine("executed");
        }

        static void MyMethod1(int i)            //with parameter 
        {
            Console.WriteLine(i);
        }
        static void MyMethod2(int i=20)            //with parameter 
        {
            Console.WriteLine(i);
        }

        static int MyMethod3(int i,int j)
        {
            return i + j;                   //return values
        }

        static void MyMethod4(string name1,string name2)        //key value pair 
        {
            Console.WriteLine(name1 + " is elder");
        }

        static int  add(int n1,int n2)
        {
          return n1 + n2;
        }

        static double add(double n1, double n2)
        {
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod1(10);      //with parameter
            MyMethod2(30);      //with default parameter method
            MyMethod2();        //with default parameter method
            Console.WriteLine(MyMethod3(10, 30)); //return values
            MyMethod4(name1: "Vaishnavi", name2: "Samruddhi");      //key value pair
            int sum1 = add(5, 5);
            double sum2 = add(5.2, 4.3);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);


        }
    }
}
