using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {//11.17 b
            int n = 12;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1638, 1900) / 10.0;
            }
            //Прямой ввод массива
            for (int i =0; i<n; i++)
            {
                Console.WriteLine(mas[i]);

            }
            Console.WriteLine();
            double a= Convert.ToDouble(Console.ReadLine());
            for (int i =0; i<n; i++)
            {
                mas[i] = mas[i] / a;

            }
            //Прямой вывод массива
            for (int i =0; i<n;i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();

        
        }
    }
}
