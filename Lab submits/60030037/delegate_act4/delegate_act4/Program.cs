using System;

namespace delegate_act4
{
    //Anonymous method
    delegate int addDel(int a, int b);
    delegate int xDel(int x);
    class Program
    {
        static void Main(string[] args)
        {
            addDel aDel = (int a, int b) => { return a + b; };
            Console.WriteLine("Result = {0}",aDel(2,3));
            xDel x = x =>  x + 3;
            Console.WriteLine("Result of xDel = {0}",x(5));
        }
    }
}
