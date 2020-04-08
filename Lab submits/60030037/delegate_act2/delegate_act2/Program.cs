using System;

namespace delegate_act2
{
    delegate void deleHello();
    class Program
    {
        static void Main(string[] args)
        {
            deleHello delH_new = new deleHello(hello);
            deleHello delH_shortcut = hello;

            delH_new();
            delH_shortcut();
        }

        public static void hello()
        {
            Console.WriteLine("Hello World.");
        }
    }
}
