using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_act1
{
    delegate void delehello(string value);
    class Program
    {
        static void Main(string[] args)
        {
            delehello delH = hello;
            delehello delG = goodbye;

            delehello delX = delH + delG + delH + delG;
            delX("ha ha ha .");
        }
        public static void hello(string value)
        {
            Console.WriteLine("From Hello : {0}", value);
        }
        public static void goodbye(string value)
        {
            Console.WriteLine("Form goodbye: {0}", value);
        }
    }
}
