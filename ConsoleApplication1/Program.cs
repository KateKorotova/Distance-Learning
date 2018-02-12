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
            int cx = 50;
            int cy = 20;
            int stepx = 1;
            int stepy = 1;
            Random r = new Random();
            int x = r.Next(0, cx);
            int y = r.Next(0, cy);
            //ConsoleKeyInfo k;
            for (;;)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(x, y);
                Console.Write('*');
                x += stepx;
                y += stepy;
                if (x >= cx)
                {
                    stepx *= -1;
                    x = cx;
                }
                if (y >= cy)
                {
                    stepy *= -1;
                    y = cy;
                }
                if (x <= 0)
                {
                    stepx *= -1;
                    x = 0;
                }
                if (y <= 0)
                {
                    stepy *= -1;
                    y = 0;
                }
                System.Threading.Thread.Sleep(8);
                Console.Clear();
            }
        }
    }
}
