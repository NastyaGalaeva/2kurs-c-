using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 50);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.Write("Как Вас зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);
        }
    }
}
