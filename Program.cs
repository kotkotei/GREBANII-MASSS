using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи массив ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(163, 190);


            }
            // Прямой ввод массива 
            Console.WriteLine();
            for (int i = n = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                mas[i] = mas[i] * 2;
            }
            //Прямой вывод массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }



            Console.ReadKey();
        }
    }
}

        




    
