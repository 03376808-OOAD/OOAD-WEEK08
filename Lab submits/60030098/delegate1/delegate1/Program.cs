using System;

namespace delegate1
{
    delegate void deleHello();
    class Program
    {
        static void Main(string[] args)
        {
            deleHello delH = hello;
            delH();
        }
        public static void hello()
        {
            Console.WriteLine("Hello World.");
        }
    }
}
