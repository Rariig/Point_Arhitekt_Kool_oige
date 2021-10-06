using System;
using System.Collections.Generic;
using System.Text;

namespace Point_Arhitekt_Kool_oige
{
    public class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X()
        {
            return x;
        }


        public double Y()
        {
            return y;
        }


        public double Rho()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // Rho() = Sqrt(x^2 + y^2)

        public double Theta()
        {
            return Math.Atan2(y, x);
        }
        // Theta() = Atan2(x,y) 

        public Point VectorTo(Point other)
        {
            return new Point(other.x - x, other.y - y);
        }

        // VectorTo = (secondPoint.x - x, secondPoint.y - y) 

        public double Distance(Point other)
        {
            return VectorTo(other).Rho();
        }

        // Distance = VectorTo(secondPoint).Rho()

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }
        // x = old x + dx
        // y = old y + dy
        public void Scale(double factor)
        {
            x *= factor;
            y *= factor;

        }
        // x = old x * factor
        // y = old y * factor
        public void Centre_rotate(double angle)
        {
            double x = Rho() * Math.Cos(Theta() + angle);
            double y = Rho() * Math.Sin(Theta() + angle);
            this.x = x;
            this.y = y;
        }

        //Theta() = oldTheta() + angle

        public void Rotate(Point other, double angle)
        {
            Move(-other.x, -other.y);
            Centre_rotate(angle);
            Move(other.x, other.y);
        }

        //p.VectorTo(this).theta() = p.VectorTo(old this).theta() + angle


        public void PrintInfo()
        {
            Console.WriteLine("X: " + X());
            Console.WriteLine("Y: " + Y());
            Console.WriteLine("Rho: " + Rho());
            Console.WriteLine("Theta: " + Theta());
        }
    }
}
