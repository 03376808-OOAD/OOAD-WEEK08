using System;

namespace delegate4
{
    delegate int addDel(int a, int b);
    delegate int xDel(int x);
    class Program
    {
        //public static int xxx(int x)
        //{
        //    return x + 3;
        //}
        static void Main(string[] args)
        {
            addDel adel = (int a,int b) => { return a + b; };
            Console.WriteLine("Result = {0}",adel(2,3));

            xDel x = x => x + 3;
            Console.WriteLine("Result of xDel = {0}",x(5));
        }
    }
}
