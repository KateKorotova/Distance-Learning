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
            int cx = 20;
            int cy = 10;
            int stepx1 = 1;
            int stepy1 = 1;
            int stepx2 = 1;
            int stepy2 = 1;
            Random r = new Random();
            int x1 = r.Next(0, cx);
            int y1 = r.Next(0, cy);
            int x2 = r.Next(0, cx);
            int y2 = r.Next(0, cy);

            for (;;)
            {
                Console.CursorVisible = false;


                if (x1 >= cx)
                {
                    stepx1 *= -1;
                    x1 = cx;
                }
                if (y1 >= cy)
                {
                    stepy1 *= -1;
                    y1 = cy;
                }
                if (x1 <= 0)
                {
                    stepx1 *= -1;
                    x1 = 0;
                }
                if (y1 <= 0)
                {
                    stepy1 *= -1;
                    y1 = 0;
                }


                if (x2 >= cx)
                {
                    stepx2 *= -1;
                    x2 = cx;
                }
                if (y2 >= cy)
                {
                    stepy2 *= -1;
                    y2 = cy;
                }
                if (x2 <= 0)
                {
                    stepx2 *= -1;
                    x2 = 0;
                }
                if (y2 <= 0)
                {
                    stepy2 *= -1;
                    y2 = 0;
                }



                if ((x1 == x2 + 1 || x1 + 1 == x2 || x1 == x2) && y1 == y2)
                {
                    x1 = x2; 
                    stepx1 *= -1;
                    stepx2 *= -1;
                    stepy1 *= -1;
                }
                if ((y1 == y2 + 1 || y2 == y1 + 1 || y1 == y2) && x1 == x2)
                {
                    y1 = y2;
                    stepy1 *= -1;
                    stepy2 *= -1;
                    stepx2 *= -1; 
                }

                Console.SetCursorPosition(x2, y2);
                Console.Write('*');
                Console.SetCursorPosition(x1, y1);
                Console.Write('*');

                x1 += stepx1;
                y1 += stepy1;

                x2 += stepx2;
                y2 += stepy2;

                System.Threading.Thread.Sleep(60);
                Console.Clear();
            }
        }
    }
}
