using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] parni = new int[10];
            int[] neparni = new int[10];

            int brojevi, p = 0, n = 0;

            do
            {
                Console.WriteLine("Unesite broj: ");
                brojevi = Convert.ToInt32(Console.ReadLine());

                if (brojevi % 2 == 0)
                {
                    parni[p++] = brojevi;
                }

                else
                {
                    neparni[n++] = brojevi;
                }

            } while (brojevi != 0 && p < 10 && n < 10);

            Console.WriteLine("Parni: ");

            for (int i = 0; i < p; i++)
            {
                Console.WriteLine(parni[i]);
            }

            Console.WriteLine("Neparni: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(neparni[i]);
            }

            Console.ReadKey();
        }
    }
}