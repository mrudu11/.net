using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_lamda_expression
{
    class MyClass<T>
    {
        public T Data;
        public void fun()
        {
            Console.WriteLine(Data);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("mrudula");  //bad way no type safty  ,need to convert typecasting 
            //Generics example
            List<int> number = new List<int>();  //only number 
            number.Add(10);
            number.Add(20);
            //number.Add("mrudula");  => error will occure compile time type checking only number allows no need of type casting
            MyClass<int> obj1 = new MyClass<int>();  //Generics => number
            obj1.Data = 10;
            obj1.fun();
            MyClass<string> obj2 = new MyClass<string>();  //Generics => string
            obj2.Data = "mrudula";                          //initialize value 
            obj2.fun();//call

            //lambda expression with list
            List<int>List2 = new List<int>() { 1,2,3,4,5};
            var even = List2.Where(n => n % 2 == 0);  //lamda expression
            foreach(var item in even)
            {
                Console.WriteLine(item);
            }

            }
        }

    }

/*Generics allow us to define classes ,methods or collections with a placeholder for a datatype  so they work with any 
 type while maintaining types safty. used for clean code.

********Acitivity****************
write a code with 2 exp with generics
where we use generics in company level.
lambda expression in c#.

write 2 exp with lambda exp 
where we use lambda exp 
create a generics class to store 2 values 
what is generics***
why generics is better than array list
what is constraints in generics.
what is lambda 
diff lambda and deligate



lambda expression is short way of writing ananomous method using arrow operator (=>)
(Parameter) => expression **** syntax

 */
