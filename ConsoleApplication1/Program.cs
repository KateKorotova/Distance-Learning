using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int cx = 20;
        static int cy = 10;

        static int numStars()
        {
            Console.WriteLine("How many stars do you prefer?");
            int num;
            bool ques = Int32.TryParse(Console.ReadLine(), out num);
            if (ques == false)
                throw new ArgumentException("Non valid data");
            return num;
        }

       public struct Star
        {
            public Star(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.stepy = 1;
                this.stepx = 1; 
            }
            public int x;
            public int y;
            public int stepx;
            public int stepy;
        }

        static Star[] createArr(int quantity)
        {
            Random r = new Random();
            Star[] stars = new Star[quantity];
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].x = r.Next(0, cx);
                stars[i].y = r.Next(0,cy);
            }
            return stars; 
        }

        static void paint(Star[] stars)
        {
            for (int i = 0; i < stars.Length; i++)
            {

            }
        }




        static void Main(string[] args)
        { 

            //for (;;)
            //{
            //    Console.CursorVisible = false;


            //    if (x1 >= cx)
            //    {
            //        stepx1 *= -1;
            //        x1 = cx;
            //    }
            //    if (y1 >= cy)
            //    {
            //        stepy1 *= -1;
            //        y1 = cy;
            //    }
            //    if (x1 <= 0)
            //    {
            //        stepx1 *= -1;
            //        x1 = 0;
            //    }
            //    if (y1 <= 0)
            //    {
            //        stepy1 *= -1;
            //        y1 = 0;
            //    }


            //    if (x2 >= cx)
            //    {
            //        stepx2 *= -1;
            //        x2 = cx;
            //    }
            //    if (y2 >= cy)
            //    {
            //        stepy2 *= -1;
            //        y2 = cy;
            //    }
            //    if (x2 <= 0)
            //    {
            //        stepx2 *= -1;
            //        x2 = 0;
            //    }
            //    if (y2 <= 0)
            //    {
            //        stepy2 *= -1;
            //        y2 = 0;
            //    }



            //    if ((x1 == x2 + 1 || x1 + 1 == x2 || x1 == x2) && y1 == y2)
            //    {
            //        x1 = x2; 
            //        stepx1 *= -1;
            //        stepx2 *= -1;
            //        stepy1 *= -1;
            //    }
            //    if ((y1 == y2 + 1 || y2 == y1 + 1 || y1 == y2) && x1 == x2)
            //    {
            //        y1 = y2;
            //        stepy1 *= -1;
            //        stepy2 *= -1;
            //        stepx2 *= -1; 
            //    }

            //    Console.SetCursorPosition(x2, y2);
            //    Console.Write('*');
            //    Console.SetCursorPosition(x1, y1);
            //    Console.Write('*');

            //    x1 += stepx1;
            //    y1 += stepy1;

            //    x2 += stepx2;
            //    y2 += stepy2;

            //    System.Threading.Thread.Sleep(60);
            //    Console.Clear();
            //}
        }
    }
}
