using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principles
{
   //ocp-open for extension and closed for modification-add new features without changing existing one
   interface IFirstInterface
    {
        void myMeth();
    }
    class Demo : IFirstInterface
    {
        public void myMeth() {
            Console.WriteLine("This is my method one interface");
        }
    }
}
