using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//11.19 b
            int n = 12;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1638, 1900); 

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            double p = 1;
            for (int i =0; i<n;i++)
            {
                p = p*mas[i];
                
            }
            Console.WriteLine("p=" + p);
            Console.ReadKey();
                


        }
        }
    }


