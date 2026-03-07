using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exp_2
{
    internal class Program
    {   class Student
        {
            private int id;                 //private data members =>encapsulation 
            private string name;            

            public void SetStudent(int sid,string sname)        //set method
            {
                id = sid;
                name = sname;
            }
            public void DisplayStudent()                    //display method
            {
                Console.WriteLine("Student id : " + id);
                Console.WriteLine("Student name : " + name);
            }
        }
        
        static void Main(string[] args)
        {
            Student stu = new Student();                    //creating object of student class
            stu.SetStudent(137,"Mrudula");                  //accessing methods using objects
            stu.DisplayStudent();                           
            Console.ReadLine();
        }
    }
}
