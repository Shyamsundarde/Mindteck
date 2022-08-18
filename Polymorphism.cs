using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT
{
    class polymorphisom
    {
        public class property
        {
            public virtual void phone()
            {
                Console.WriteLine("only phone is needed");
            }
        }
        public class me : property
        {
            public override void phone()
            {

                Console.WriteLine("Money is also need");
            }
            static void Main()
            {
                me p = new me();
                p.phone();
            }

        }
    }
}