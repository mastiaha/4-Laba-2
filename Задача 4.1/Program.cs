using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1, sqr = 0; i <=n; i++)

            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, sqr += 2 * i - 1);
               
            }
            Console.WriteLine("Для выхода из программы нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
        
    }
}
