using System;

namespace delegate_act1
{
    delegate void deleHello(string value);
    class Program
    {
        static void Main(string[] args)
        {
            deleHello delH = hello;
            delH("Sawasdee krub.");
            deleHello delG = goodbye;
            delG("bye bye.");
        }

        public static void hello(string value)
        {
            Console.WriteLine(value);
        }
        public static void goodbye(string value)
        {
            Console.WriteLine(value);
        }
    }
}
