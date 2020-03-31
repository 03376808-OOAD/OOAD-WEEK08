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

            delMove[] arrDel = new delMove[10];
            arrDel[0] = L;
            arrDel[1] = L;
            arrDel[2] = R;
            arrDel[3] = L;
            arrDel[4] = R;
            arrDel[5] = L;
            arrDel[6] = R;
            arrDel[7] = L;
            arrDel[8] = R;
            arrDel[9] = L;

            foreach (delMove x in arrDel)
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
