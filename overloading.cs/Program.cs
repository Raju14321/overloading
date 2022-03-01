using System;

namespace overloading.cs
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("metho 1");
        }
        public void Test(int i)
        {
            Console.WriteLine("Gives num 1432");
        }
        public void Test(string a)
        {
            Console.WriteLine("raju");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Test("lucky");
            Console.ReadLine();
        }
    }
}
