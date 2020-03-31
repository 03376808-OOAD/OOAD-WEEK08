using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_act2
{
    delegate void deleHello(string value);
    class Program
    {
        static void Main(string[] args)
        {
            deleHello delH = hello;
            deleHello delG = goodbye;
            deleHello delX = delH + delG + delH + delG;
            delX("ha ha ha.");
        }

        public static void hello(string value)
        {
            Console.WriteLine("Form Hello : {0}",value);
        }

        public static void goodbye(string value)
        {
            Console.WriteLine("Form Goodbye : {0}",value);
        }
    }
}
