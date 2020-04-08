using System;

namespace delegate_act4
{
    //Anonymous method
    class Program
    {
        public static int add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("result={0}",add(2,3));
        }
    }
}
