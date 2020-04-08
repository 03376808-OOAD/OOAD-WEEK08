using System;

namespace delegate_act4
{
    //Anonymous method
    delegate int addDel(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            addDel aDel = delegate (int a, int b) { return a + b; };
            Console.WriteLine("result={0}",aDel(2,3));
        }
    }
}
