using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT
{
    class abstractclass
    {
        public abstract class operation
        {
            public abstract void Mul(int x, int y);
            public abstract void Div(int x, int y);


        }
        class child : operation
        {
            public override void Mul(int x, int y)
            {
                Console.WriteLine("The result is" + "" + x * y);
            }
            public override void Div(int x, int y)
            {
                Console.WriteLine("The result is" + "" + x / y);
            }
            static void Main()
            {
                child c = new child();
                c.Mul(20, 10);
                c.Div(10, 5);
            }

        }

    }
}