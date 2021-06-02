using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  //11.17 a
            Console.WriteLine("ВВод масив");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(163, 190);

            }
            for (int i =0;i<n;i++)
            {
                Console.WriteLine(mas[i] + "");
            }
            //В обратном порядке
            Console.WriteLine();
            for (int i = n - 1; i > 0; i++) ;
            Console.ReadKey();
        }
    }
}
