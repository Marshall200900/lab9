using System;

namespace prog99
{
    public class PointArray
    {
        Point[] points;
        int size;
        public Point this[int index]
        {
            get
            {
                return points[index];
            }
            set
            {
                points[index] = value;
            }
        }

        public PointArray(int size)
        {
            points = new Point[size];

            this.size = size;
        }
        public double FindShortestDistance()
        {
            Point p = points[0];
            for(int i = 1; i < size; i++)
            {
                if (Point.OriginDistance(points[i]) < p)
                {
                    p = points[i];
                }
            }
            return Point.OriginDistance(p);
        }

        public PointArray(bool random, int size)
        {
            points = new Point[size];
            this.size = size;
            if (random)
            {

                Random rnd = new Random();
                for(int i = 0; i < size; i++)
                {
                    points[i] = new Point(rnd.NextDouble() * 10, rnd.NextDouble() * 10);
                }
            }
            else
            {
                for(int i = 0; i < size; i++)
                {
                    double x = Program.Input($"Введите координату x {i + 1}-го числа: ");
                    double y = Program.Input($"Введите координату y {i + 1}-го числа: ");
                    points[i] = new Point(x, y);
                }
            }
        }

    }
}
