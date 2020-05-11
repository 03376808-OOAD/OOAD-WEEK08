using System;

namespace Delegate4
{
    delegate int addDel(int a, int b);
    delegate int xDel(int x);
    class Program
    {
        static void Main(string[] args)
        {
            addDel aDel = (int a, int b) => { return a + b; }; //Lamda Expression

            Console.WriteLine("Relust = {0}", aDel(2, 3));


            xDel x = X => X + 3; ;
            Console.WriteLine("Result of Xdel = {0}", x(5));

            Console.ReadKey();
        }

    }
}
