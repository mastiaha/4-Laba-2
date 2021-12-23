using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 1000;
            double p = 4;
            double Sum2 = Sum * 2;
            int year = 0;
            while (Sum<Sum2)
            {
                Sum += Sum * 4 / 100;
                ++year;
            }
            Console.WriteLine(year);
            Console.ReadKey();
        }
    }
}
