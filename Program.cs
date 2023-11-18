using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(
                Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine($"{sayi} çift sayıdır.");
            else
                Console.WriteLine($"{sayi} Tek sayıdır.");

            Console.ReadKey();
        }
    }
}
