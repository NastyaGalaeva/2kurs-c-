using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Какую строку нужно найти в изначальной строке? ");
            string str = Console.ReadLine();
            int i = stroka.LastIndexOf(str);//с конца
            int j = stroka.IndexOf(str);//с начала 
            if (i != -1)
                if (j != -1)
                {
                    Console.WriteLine("Индекс после поиска с конца " + i);
                    Console.WriteLine("Индекс после поиска с начала " + j);
                }
            if (i == -1)
                if (j == -1)
                {
                    Console.WriteLine("Этой строки нет в изначальной строке! ");
                }

            string[] massiv = stroka.Split('.');//Разбить строку на массив строк с помощью символа-разделителя
            Console.WriteLine("Если разделить изначальную строку символом, получим: ");
            foreach (string st in massiv)
                Console.WriteLine(st);

            Console.WriteLine("Введите элементы первого массива через пробел");
            string[] massiv1 = Console.ReadLine().Split(new char[] { ' ' });
            Console.WriteLine("Введите элементы второго массива через пробел");
            string[] massiv2 = Console.ReadLine().Split(new char[] { ' ' });            
            StringBuilder stroka2 = new StringBuilder();
            foreach (string a in massiv1)             
                {
                    stroka2.Append(a);                        
                }
            foreach (string b in massiv2)
                {
                    stroka2.Append(b);
                }
            Console.WriteLine("Собранная строка из двух массивов строк: " + stroka2);

            Console.WriteLine("Введите строку для смены в ней регистра ");
            string stroka3 = Console.ReadLine();
            string stroka3_toupper = stroka3.ToUpper();
            Console.WriteLine("Верхний регистр " + stroka3_toupper);
            string stroka3_tolower = stroka3.ToLower();
            Console.WriteLine("Нижний регистр " + stroka3_tolower);







        }
    }
}
