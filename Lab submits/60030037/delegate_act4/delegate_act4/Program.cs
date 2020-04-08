using System;

namespace delegate_act4
{
    //Anonymous method
    delegate int addDel(int a, int b);
    class Program
    {
        public static int add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            addDel aDel = add;
            Console.WriteLine("result={0}",aDel(2,3));
        }
    }
}
