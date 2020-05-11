using System;

namespace Delegate3
{
    delegate void delMove();
    class Program
    {
        static void Main(string[] args)
        {
            delMove L = turnLeft;
            delMove R = turnRight;
            delMove gotoSchool = L;

            delMove[] arrdel = new delMove[10];
            arrdel[0] = L;
            arrdel[1] = L;
            arrdel[2] = R;
            arrdel[3] = L;
            arrdel[4] = R;
            arrdel[5] = L;
            arrdel[6] = R;
            arrdel[7] = L;
            arrdel[8] = R;
            arrdel[9] = L;

            foreach (delMove x in arrdel)
            {
                gotoSchool += x;
            }
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
