using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Licz
    {
        private int value;

        public Licz(int initialValue)
        {
            value = initialValue;
        }

        public void Dodaj (int x)
        {
            value += x;
        }

        public void Odejmij(int x)
        {
            value -= x;
        }

        public void Wyswietli()
        {
            Console.WriteLine($"Value = {value}"); 
        }


    }

}
