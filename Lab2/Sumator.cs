using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   class Sumator
   {
        private int[] Liczby;

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int Suma()
        {
            int suma = 0;
            foreach(int x  in Liczby) 
                suma += x;
            return suma;
        }

        public int SumaPod2()
        {
            int suma = 0;
            foreach (int x in Liczby)
                if (x % 2 == 0)
                    suma += x;
            return suma;
        }

        public int IleEl()
        {
            return Liczby.Length;
        }

        public void WypWszys()
        {
            Console.WriteLine("Wszystkie elementy: ");
            foreach (int x in Liczby)
                Console.WriteLine(x + " ");
            Console.WriteLine();
        }

        public void WypZak(int lowInd, int hightInd)
        {
            if (lowInd < 0) 
                lowInd = 0;
            if(hightInd >= Liczby.Length)
                hightInd = Liczby.Length - 1;

            Console.WriteLine($"\nElementy od indeksu {lowInd} do {hightInd}");

            for(int i = lowInd;  i <= hightInd; i++)
                Console.WriteLine(Liczby[i] + " ");

            Console.WriteLine();

        }
   }
}
