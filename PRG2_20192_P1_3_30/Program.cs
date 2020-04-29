using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_3_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("ANAK AYAM TURUN ");n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            for (int i = n; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", i);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", i, i-1);
                }
                
            }
        }
    }
 }
