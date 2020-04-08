using System;

namespace delegate_act1
{
    //Anonymous method

    delegate int addDel(int a, int b);
    delegate int xDel(int x);
    class Program
    {
        static void Main(string[] args)
        {
            addDel adel = (int a, int b) => { return a + b; }; //Lambda Expression
            Console.WriteLine("result = {0}",adel(2,3));

            xDel x = x => x + 3; //Lambda Expression
            Console.WriteLine("Result of xDel = {0}",x(5));
        }
    }
}
