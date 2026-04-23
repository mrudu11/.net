using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles
{
    //ISP-Interface Segregation Principle (ISP)-Don't force class to implement the method that it does not need
    interface Work
    {
        void workable();
    }
    interface Eat
    {
        void eatable();
    }

    class Human : Work,Eat
    {
        public void workable()
        {
            Console.WriteLine("Human can work");
        }
        public void eatable()
        {
            Console.WriteLine("Human can eat");
        }
    }
    class Robot : Work {
        public void workable()
        {
            Console.WriteLine("Robots can work");
        }
    }
}
