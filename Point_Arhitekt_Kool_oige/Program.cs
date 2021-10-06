using System;

namespace Point_Arhitekt_Kool_oige
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point a = new Point(10, 20);
            //a.x = 10;
            //a.y = 20;
            //Point b = new Point(50, 60);
            //b.x = 50;
            //b.y = 60;
            //b.PrintInfo();
            //b.Scale(5);
            //b.PrintInfo();
            //b.Move(10, 15);
            //b.PrintInfo();
            //b.Distance(a);

            Point a = new Point(10, 20);
            Point b = new Point(-20, 60);
            b.PrintInfo();
            b.Distance(a);

            Point c = new Point(15, 0);
            c.Centre_rotate(Math.PI / 3);
            c.PrintInfo();

            //Point a = new Point(10, 20);
            //Point b = new Point(15, 16);
            //a.Rotate(b, 1.1);
            //a.PrintInfo();
            //b.Rotate(a, 1.1);
            //b.PrintInfo();
        }
    }
}
