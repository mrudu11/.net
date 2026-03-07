using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
    {   class Person
        {
            private string name;
            public void SetName(string pname)
            {
                name = pname;
            }
            public void DisplayName()
            {
                Console.WriteLine("person name : " + name);
            }
        }
        //inheritance : derived class
        class Student : Person
        {
            public void ShowDetails(int id)                     //polymorphism
            {
                Console.WriteLine("Student Id : " + id);
            }
            public void ShowDetails(int id,string course)
            {
                Console.WriteLine("Student Id : " + id);
                Console.WriteLine("Student course : " + course);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("set method=>set name");
            s1.SetName("Mrudula");
            Console.WriteLine("Display method");
            s1.DisplayName();
            //derived class methods accessed using objects
            Console.WriteLine("show method with one parameter");
            s1.ShowDetails(137);
            Console.WriteLine("show method with two parameters");
            s1.ShowDetails(137, "Mrudula");
            Console.ReadLine();

        }
    }
}
