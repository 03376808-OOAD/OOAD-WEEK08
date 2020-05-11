using System;

namespace Delegate2
{
    delegate void deleHello(string Hello);
    class Program
    {
        static void Main(string[] args)
        {
            deleHello delH = hello;
            deleHello delG = goodbye;
            deleHello delX = delH + delG + delH + delG;
            delX("ha ha ha.");
            Console.ReadKey();
        }
        public static void hello(string value)
        {
            Console.WriteLine("From Hello : {0}", value);
        }
        public static void goodbye(string value)
        {
            Console.WriteLine("Frin Goodbye : {0}", value);
        }
    }
}
