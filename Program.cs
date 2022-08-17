using System;
namespace myconsoleapplication
{
    class shyam
    {
        public delegate void Shyamdeligate(string name);
        public delegate void Multideligate(int x, int y);
        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);

        }
        public void name(string name)
        {
            Console.WriteLine("my name is" + " " + name);

        }
        static void Main(string[] args)
        {
            shyam d = new shyam();
            Shyamdeligate obj1 = new Shyamdeligate(d.name);
            Multideligate obj2 = new Multideligate(d.Multi);
            obj1("Shyam");
            obj2(10, 20);

        }

    }
}


    //Exception
