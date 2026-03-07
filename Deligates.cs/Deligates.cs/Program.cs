//function or methods address store and reference => deligates
//types safe reference to a method means it store address of method and call it later
//variable that points to function 
//where we use =>event handling programs
//if we call function many times it  will give  low performance then we call deligates
//it can't change function 
//deligate is middle term bet object and function connect two sides direct affect 
//single cast deligate =>
//multiple cast 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Deligates.cs
{
    internal class Program
    {   public void myFun()
        {
            Console.WriteLine("hello");
        }
        public  void myFun1()
        {
            Console.WriteLine("hello");
        }
        public void myFun2()
        {
            Console.WriteLine("hello");
        }

        public  delegate void MyDeligate();
        
        
        static void Main(string[] args)
        {
            Program obj = new Program();                    //single delegate
            MyDeligate Del = new MyDeligate(obj.myFun);
            Del();
            Del -= obj.myFun1;                      //multiple delegate
            Del();
            Del += obj.myFun2;
        }
    }
}


//Exception => An error that happens while program is running.
//Exception handling is used to Prevent program crash ,Show user-friendly message , Handle errors properly
//try → write risky code
//catch → handles error
//finally → always runs


//Class to Class Method Communication => One class calling method of another class.

//communication bet class and object => class is blue print and logical entity =>object is real thing created from class and physical entity

//   Reusability in C# => use inheritance 

// C# + ADO.NET Connectivity =>technology that used to connect c# with database

