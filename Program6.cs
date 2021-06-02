using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {//11.29 b
            Console.WriteLine("Введи длин массив ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(50, 70);
                Console.WriteLine(mas[i]);
            }
            double m = 0;
            for (int i = 0; i < n; i++)
            {
                m = m + Math.Pow(mas[i], 2);
            } Console.WriteLine(m);
            if (9999 < m && m < 100000)
               
            {
                Console.WriteLine("Пятизнач");

            }
            else
            {
                Console.WriteLine("Не Пятизнач");
            }
            Console.ReadKey();


        }
    }
}
