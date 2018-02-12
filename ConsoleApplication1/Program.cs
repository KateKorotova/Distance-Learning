using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int cx = 50;
        static int cy = 20;

        static int numStars()
        {
            Console.WriteLine("How many stars do you prefer?");
            int num;
            bool ques = Int32.TryParse(Console.ReadLine(), out num);
            if (ques == false || num == 0)
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
                stars[i] = new Star(r.Next(0, cx), r.Next(0, cy));

            }
            return stars; 
        }

        static void checkBoard(ref Star[] stars)
        {
            for ( int i = 0; i < stars.Length; i++)
            {
                if (stars[i].x >= cx)
                {
                    stars[i].stepx *= -1;
                    stars[i].x = cx;
                }
                if (stars[i].y >= cy)
                {
                    stars[i].stepy *= -1;
                    stars[i].y = cy;
                }
                if (stars[i].x <= 0)
                {
                    stars[i].stepx *= -1;
                    stars[i].x = 0;
                }
                if (stars[i].y <= 0)
                {
                    stars[i].stepy *= -1;
                    stars[i].y = 0;
                }
            }
        }

        static void checkPos(ref Star[] stars)
        {
            for (int i = 0; i < stars.Length; i++)
                for( int j = i + 1; j < stars.Length; j++)
                {
                    if ((stars[i].x == stars[j].x + 1 || stars[i].x + 1 == stars[j].x || stars[i].x == stars[j].x) && stars[i].y == stars[j].y)
                    {
                        stars[i].x = stars[j].x;
                        stars[i].stepx *= -1;
                        stars[j].stepx *= -1;
                        stars[i].stepy *= -1;
                    }
                    if ((stars[i].y == stars[j].y + 1 || stars[i].y == stars[j].y + 1 || stars[i].y == stars[j].y) && stars[i].x == stars[j].x)
                    {
                        stars[i].y = stars[j].y;
                        stars[i].stepy *= -1;
                        stars[j].stepy *= -1;
                        stars[j].stepx *= -1;
                    }
                }
        }

        static void paint(ref Star[] stars)
        {
            while (true)
            {
                Console.CursorVisible = false;

                for (int i = 0; i < stars.Length; i++)
                {
                    Console.SetCursorPosition(stars[i].x, stars[i].y);
                    Console.Write('*');
                    stars[i].x += stars[i].stepx;
                    stars[i].y += stars[i].stepy;
                }

                checkBoard(ref stars);
                checkPos(ref stars);
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }




        static void Main(string[] args)
        {
            int quantity;
            while (true)
            {
                try
                {
                    quantity = numStars();
                    break;
                }
                catch (ArgumentException ex)
                {
                    string e = ex.Message;
                    Console.WriteLine(e);
                }
            }
            Star[] stars = createArr(quantity);
            paint(ref stars);
        }
    }
}
