using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите год ");
                int num_year = Convert.ToInt32(Console.ReadLine());

                bool what_year = (num_year % 4 == 0) && (num_year % 100 != 0 || num_year % 400 == 0);
                //if (what_year)
                //{ Console.WriteLine("Введенный год - високосный"); }
                //else
                //{ Console.WriteLine("Введенный год - не високосный"); }
                int max_num_day = what_year ? 366 : 365;

                Console.Write("Введите номер дня в году от 1 до {0} ", max_num_day);
                int num_day = Convert.ToInt32(Console.ReadLine());

                if (num_day < 1 || num_day > max_num_day)
                { throw new ArgumentOutOfRangeException("Вы ввели недопустимый день года"); }

                int num_month = 0;
                if (num_day <= 31) { goto End; } //Январь
                else { num_day -= 31; num_month++; }
                if (what_year)
                {
                    if (num_day <= 29) { goto End; } //Февраль
                    else { num_day -= 29; num_month++; }
                }
                else
                {
                    if (num_day <= 28) { goto End; } //Февраль
                    else { num_day -= 28; num_month++; }
                }
                if (num_day <= 31) { goto End; } //Март
                else { num_day -= 31; num_month++; }
                if (num_day <= 30) { goto End; } //Апрель
                else { num_day -= 30; num_month++; }
                if (num_day <= 31) { goto End; } //Май
                else { num_day -= 31; num_month++; }
                if (num_day <= 30) { goto End; } //Июнь
                else { num_day -= 30; num_month++; }
                if (num_day <= 31) { goto End; } //Июль
                else { num_day -= 31; num_month++; }
                if (num_day <= 31) { goto End; } //Август
                else { num_day -= 31; num_month++; }
                if (num_day <= 30) { goto End; } //Сентябрь
                else { num_day -= 30; num_month++; }
                if (num_day <= 31) { goto End; } //Октябрь
                else { num_day -= 31; num_month++; }
                if (num_day <= 30) { goto End; } //Ноябрь
                else { num_day -= 30; num_month++; }
                if (num_day <= 31) { goto End; } //Декабрь
                else { num_day -= 31; num_month++; }
                End:

                MonthName temp = (MonthName)num_month;
                string name_month = temp.ToString();
                Console.WriteLine("{0} {1}", num_day, name_month);
            }
            catch (Exception caught)
            { Console.WriteLine(caught); }
        }
    }
}