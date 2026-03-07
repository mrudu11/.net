class Program
    {
        static void Main(string[] args)
        {
            string name = "Mdrudula";  //string variable
            System.Console.WriteLine(name);

            int Num = 15;
            Num = 20;                 //assign a new value to an existing variable, it will overwrite the previous value
            System.Console.WriteLine(Num); 

            double DoubleNum = 5.99D;  //double
            System.Console.WriteLine(DoubleNum); 

            char Letter = 'D';        //character
            System.Console.WriteLine(Letter); 

            bool Bool = true;           //boolean
            System.Console.WriteLine(Bool); 

            const int Num1 = 10;  //can't assign value again ,const shows that the value assign to that variable is fixed

            string name2 = "John";                   //Display Variables
            System.Console.WriteLine("Hello " + name2);
        }
    }
