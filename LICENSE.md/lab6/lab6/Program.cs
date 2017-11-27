using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stat_massiv = { 77, 12, 74, 34, 56, 78, 234, 678 };
            Console.WriteLine("Начальный статический массив: ");
            for (int i = 0; i < stat_massiv.Length; i++)
            {
                Console.WriteLine( stat_massiv[i]);
            }

            Array.Sort(stat_massiv);
            Console.WriteLine("Отсортированный статический массив: ");
            for (int i = 0; i < stat_massiv.Length; i++)
            {
                Console.WriteLine(stat_massiv[i]);    
            }
                        
            for (int i = 0; i < stat_massiv.Length; i++)
            {                
                if (stat_massiv[i] == 56)
                {
                    Console.WriteLine("Индекс элемента 56: " + i);
                }
            }

            int[] din_massiv = { 77, 12, 74, 34, 56, 78, 234, 678 };
            Console.WriteLine("Начальный динамический массив: ");
            for (int i = 0; i < din_massiv.Length; i++)
            {
                Console.WriteLine(din_massiv[i]);
            }
            ArrayList din_massivList = new ArrayList();
            Array.ForEach(din_massiv, i => din_massivList.Add(i));
            din_massivList.Remove(56);            
            object[] din_massiv2 = din_massivList.ToArray();
            Console.WriteLine("Динамический массив после удаления элемента 56: ");
            for (int i = 0; i < din_massiv2.Length; i++)
            {
                Console.WriteLine(din_massiv2[i]);
            }

            int[,] A = { { 2, 1 }, { 1, 3 } };
            int[,] B = { { 1, 2 }, { 3, 1 } };
            int C1 = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            int C2 = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            int C3 = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            int C4 = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];
            Console.WriteLine("Результирующая матрица: ");
            Console.WriteLine("( " + C1 + " " + C2);            
            Console.WriteLine(" " + C3 + " " + C4 + " )");

            int[] massiv = { 77, 12, 74, 34, 56, 78, 234, 678 };
            Hashtable hashtable = new Hashtable();
            foreach (int num in massiv)
            {
                hashtable.Add(num, string.Format("Элемент {0}", num));
            }
            Console.WriteLine("Элемент по ключу 56: " + (string)hashtable[56]);
        }
    }
}
