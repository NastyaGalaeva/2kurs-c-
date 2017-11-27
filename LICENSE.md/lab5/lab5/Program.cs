using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек квадрата: ");
            Console.Write("X1 = ");
            double X1 = double.Parse(Console.ReadLine());
            Console.Write("Y1 = ");
            double Y1 = double.Parse(Console.ReadLine());
            Console.Write("X2 = ");
            double X2 = double.Parse(Console.ReadLine());
            Console.Write("Y2 = ");
            double Y2 = double.Parse(Console.ReadLine());
            Console.Write("X3 = ");
            double X3 = double.Parse(Console.ReadLine());
            Console.Write("Y3 = ");
            double Y3 = double.Parse(Console.ReadLine());
            Console.Write("X4 = ");
            double X4 = double.Parse(Console.ReadLine());
            Console.Write("Y4 = ");
            double Y4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь квадрата = " + Class1.Square.Area(X1, Y1, X2, Y2, X3, Y3, X4, Y4)); //Вычисляю и вывожу площадь
            Console.WriteLine("Периметр квадрата = " + Class1.Square.Perimetr(X1, Y1, X2, Y2, X3, Y3, X4, Y4)); //Вычисляю и вывожу периметр

            Console.WriteLine("Введите числа для подсчета суммы через пробел: ");
            string[] StringNumbers = Console.ReadLine().Split(new char[] { ' ' });
            Console.WriteLine("Сумма чисел равна " + Class1.Sum.Sum1(StringNumbers));

            Console.WriteLine("Введите два числа  для перестановки их местами ");
            Console.WriteLine("Первое:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Второе:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("До перестановки: " + x + ", " + y);
            Class1.Perestanovka.Perest(ref x, ref y);
            Console.WriteLine("После перестановки: " + x + ", " + y);

            Console.WriteLine("Введите число, для которого нужно вычислить факториал ");
            int xn = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Факториал числа " + xn + " равен " + Class1.Factorial.Fact(xn));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Нельзя вычислить факториал для отрицательного числа ");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка из-за переполнения ");
            }
        }
    }
}
