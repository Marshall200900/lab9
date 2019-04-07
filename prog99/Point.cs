using System;

namespace prog9cons
{
    public class Point
    {
        // Автоматические свойства
        public double X { get; set; }
        public double Y { get; set; }

        //Конструкторы
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Методы
        public double OriginDistance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static double OriginDistance(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        //Перегрузка операторов
        public static Point operator --(Point a)
        {
            a.X--;
            a.Y--;
            return a;
        }
        
        public static Point operator -(Point a)
        {
            double temp = a.X;
            a.X = a.Y;
            a.Y = temp;
            return a;
        }
        public static Point operator -(Point a, double x)
        {
            a.X -= x;
            return a;
        }
        public static Point operator -(double y, Point a)
        {
            a.Y = a.Y-y;
            return a;
        }
        public static double operator -(Point p, Point p2)
        {
            return Math.Sqrt(Math.Pow((p.X - p2.X), 2) + Math.Pow((p.Y - p2.Y), 2));
        }

        public static implicit operator int(Point p)
        {
            return (int)Math.Truncate(p.X);
        }
        public static explicit operator double(Point p)
        {
            return p.Y;
        }

        //Перегрузка ToString()
        public override string ToString()
        {
            return "(" + string.Format("{0:0.00}", X) + ":" + string.Format("{0:0.00}", Y) + ")";
        }


    }
}
