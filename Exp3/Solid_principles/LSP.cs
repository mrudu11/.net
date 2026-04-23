using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles
{
    class Bird
    {
    }

    // Birds that can fly
    class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("This bird can fly");
        }
    }

    // Sparrow can fly
    class Sparrow : FlyingBird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    // Ostrich cannot fly
    class Ostrich : Bird
    {
        public void Run()
        {
            Console.WriteLine("Ostrich is running");
        }
    }
}
