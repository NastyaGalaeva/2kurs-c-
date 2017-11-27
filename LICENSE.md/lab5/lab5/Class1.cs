using System;
using System.Collections.Generic;

namespace lab5
{
    internal class Class1
    {
        public struct Square
        {
            public static double Area(double X1, double Y1, double X2, double Y2,
                double X3, double Y3, double X4, double Y4)
            {
                double lengthAB = System.Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)); // Длина стороны AB
                double area = lengthAB * lengthAB; // Площадь 
                return area;
            }
            public static double Perimetr(double X1, double Y1, double X2, double Y2,
                double X3, double Y3, double X4, double Y4)
            {
                double lengthAB = System.Math.Sqrt(System.Math.Pow(X1 - X2, 2) + System.Math.Pow(Y1 - Y2, 2)); // Длина стороны AB
                double perimetr = 4 * lengthAB; // Периметр
                return perimetr;
            }
        }
        public struct Sum
        {
            public static double Sum1(string[] StringNumbers)
            {
                double[] numbers = new double[StringNumbers.Length];
                for (int i=0; i<numbers.Length; ++i)
                {
                    numbers[i] = Convert.ToDouble(StringNumbers[i]);
                }
                double sum = 0;
                foreach (double n in numbers)
                {
                    sum += n;
                }
                return sum;
            }
        }

        public struct Perestanovka
        {
            public static void Perest(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }

        public struct Factorial
        {
            public static long Fact(int xn)
            {
                checked
                {
                    int x = 1;
                    if (xn < 0) throw new ArgumentOutOfRangeException();
                    if (xn == 0) return x;
                    else
                    {
                        for (int i = 2; i <= xn; ++i)
                        {
                            x *= i;
                        }
                    }
                    return x;
                }                
            }
        }
    }
}