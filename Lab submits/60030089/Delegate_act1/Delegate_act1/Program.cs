using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_act1
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
