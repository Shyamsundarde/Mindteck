using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Mindteck";
            string rev = "";
           int len = word.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                rev=rev+word[i];
            }
            Console.WriteLine(rev);
        }
    }
}

