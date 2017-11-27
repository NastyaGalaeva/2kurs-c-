using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество дат: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            DateTime[] date_time = new DateTime[lenght];
            date_time[0] = DateTime.Now;            
            int b = 3;
            Console.WriteLine("Даты: ");
            Console.WriteLine(date_time[0]);            
            for (int i = 1; i < lenght; i++)
            {
                date_time[i] = date_time[i - 1].AddDays(b);
                b = b + 3;
                Console.WriteLine(date_time[i]);
            }
        }
    }
}
