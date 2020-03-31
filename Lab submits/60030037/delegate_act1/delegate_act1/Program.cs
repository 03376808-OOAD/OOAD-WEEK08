using System;

namespace delegate_act1
{
    //Anonymous method

    delegate int addDel(int a, int b);
    class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            addDel adel = add;
            Console.WriteLine("result = {0}",adel(2,3));
        }
    }
}
