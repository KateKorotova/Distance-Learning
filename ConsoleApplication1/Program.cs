using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10,
    b = a / 5;

            if (b <= 2)
            {
                Console.WriteLine("Менше або дорівнює двом");
            }
            else if (b == 2)
            {
                Console.WriteLine("Дорівнює двом");
            }
            Console.ReadKey();
        }
    }
}
