using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "mrudula";

            Console.WriteLine(fname);       //returns string 
            Console.WriteLine(fname.Length);        //string length
            Console.WriteLine(fname.ToLower());     //lower case
            Console.WriteLine(fname.ToUpper());     //upper case

            string lName = "waghmode";
            string name = fname + lName;        //string concatination without space add 2 string
            Console.WriteLine(name);

            string firstName = "smaruddhi";
            string lastName = " shingade";
            string name3 = string.Concat(firstName, lastName);  //string concatination with space add 2 string
            Console.WriteLine(name3);

            string x = "10";      
            string y = "20";
            string z = x + y;          //output = 1020 add two strings
            Console.WriteLine(z);

            string name4 = $"My full name is: {firstName} {lastName}";  //string concatination
            Console.WriteLine(name4);           

            Console.WriteLine(fname[0]);                //position element
            Console.WriteLine(fname.IndexOf("r"));         //index of character

            
            string name5 = "mrudula waghmode";
            int charPos = name5.IndexOf("w");  
            string lastName1 = name5.Substring(charPos);    //substring

            Console.WriteLine(lastName1);

            string txt = "We are the so-called \"Vikings\" \nfrom the north.";  //add double qoute and \n new line
            string txt1 = "We are the so-called \'Vikings\' \t from the north."; //add single qoute and \t tab
            string txt2 = "We are the so-called \\Vikings\\ \bfrom the north.";   //add single \  \b backspace
            Console.WriteLine(txt);
            Console.WriteLine(txt1);
            Console.WriteLine(txt2);

            
        }
    }
}
