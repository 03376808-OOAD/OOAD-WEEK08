using System;

namespace delegate_act1
{
    //adding methods to delegate
    delegate void delMove();
    class Program
    {
        static void Main(string[] args)
        {
            delMove L = turnLeft;
            delMove R = turnRight;
            delMove gotoSchool = L;
            gotoSchool += L;
            gotoSchool += R;
            gotoSchool += R;
            gotoSchool += L;
            gotoSchool += L;
            gotoSchool += R;
            gotoSchool += L;
            gotoSchool();
        }

        static public void turnLeft()
        {
            Console.WriteLine("Turn Left.");
        }

        static public void turnRight()
        {
            Console.WriteLine("Turn Right.");
        }

    }
}
