using System;

namespace Delegate1
{
    delegate void delehello();
    class Program
    {
        static void Main(string[] args)
        {
            delehello delH = hello;
            delH();
        }
        public static void hello()
        {
            Console.WriteLine("Hello World.");
        }
    }
}
