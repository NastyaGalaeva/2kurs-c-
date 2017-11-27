using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    struct Point
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double dist(Point P)
        {
            return Math.Sqrt((this.x - P.x) * (this.x - P.x) + (this.y - P.y) * (this.y - P.y));
        }
    }


    class Program
    {
        enum Form { ZAO, OOO, IP }
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной х = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = (3 * x * x + 4 * x * x - 2 * x + 1);
            Console.WriteLine("y = " + y);

            int a = (int)Form.ZAO;
            int b = (int)Form.IP;
            Console.WriteLine("ZAO = {0}", a);
            Console.WriteLine("IP = {0}", b);

            Point[] P = new Point[4];
            P[0] = new Point(1, 1);
            P[1] = new Point(1, 6);
            P[2] = new Point(6, 6);
            P[3] = new Point(6, 1);
            double[] L = new double[3];
            L[0] = P[0].dist(P[1]);
            L[1] = P[0].dist(P[2]);
            L[2] = P[0].dist(P[3]);
            Array.Sort(L);
            double Perimeter = 4 * L[0];
            double Area = L[0] * L[0];
            Console.WriteLine("Длина стороны квадрата = {0}", L[0]);
            Console.WriteLine("Периметр квадрата = {0}", Perimeter);
            Console.WriteLine("Площадь квадрата = {0}", Area);
        }
    }
}
