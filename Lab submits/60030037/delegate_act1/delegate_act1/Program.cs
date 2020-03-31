using System;

namespace delegate_act1
{
    //Anonymous method

    delegate int addDel(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            addDel adel = (int a, int b)=>{
                return a + b;
            };
            Console.WriteLine("result = {0}",adel(2,3));
        }
    }
}
