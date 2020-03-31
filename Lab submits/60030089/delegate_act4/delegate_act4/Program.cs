using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_act4
{
    delegate int addDel(int a, int b);
    delegate int xDel(int X);
    class Program
    {
        static void Main(string[] args)
        {
            addDel adel = (int a, int b) => { return a + b; };
            Console.WriteLine("result ={0}", adel(2, 3));
            {
                xDel x = X => X + 3;
                Console.WriteLine("result of xDel = {0}", x(5));
            }

        }
    }
}
