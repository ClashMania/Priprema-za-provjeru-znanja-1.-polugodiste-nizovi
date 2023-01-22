using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = { 1, 5, 7, 2, 8, 1, 3 };
            int[] niz2 = { 2, 5, 7, 8, 8 };
            int manji, broj = 0;

            if (niz1.Length < niz2.Length)
            {
                manji = niz1.Length;
            }
            else
            {
                manji = niz2.Length;
            }

            for (int i = 0; i < manji; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    broj++;
                }
            }

            Console.WriteLine("Broj istih vrijednosti na istim indeksima je " + broj);

            Console.ReadKey();
        }
    }
}
