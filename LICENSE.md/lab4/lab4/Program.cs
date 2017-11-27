using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static double SSS(double x)
        {
            if (x < 0) throw new ArgumentException();
            if (x == 0) throw new DivideByZeroException();

            return (3 * Math.Pow(x, -2) + 4 / x - 2 * Math.Pow(x, 1.0 / 2) + 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной х = ");
            int x = Convert.ToInt32(Console.ReadLine());

            try
            {
               Console.WriteLine("y = " + SSS(x));                
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль недопустимо");                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка: Нельзя вычислять квадратный корень из отрицательного числа");
            }            
        }
    }
}
