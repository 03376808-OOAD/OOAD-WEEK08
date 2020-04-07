using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    //adding metgods delegate
    delegate void delHello();
    class Program
    {
        static void Main(string[] args)
        {
            delHello delH = hello;
            delH();
            Console.ReadKey();
        }
        static public void hello()
        {
            Console.WriteLine("Hello World.");
        }
      
    }
}
