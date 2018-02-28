using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ball
    {
        public static int cx = 50;
        public static int cy = 20;
        internal Ball()
        {
            r = 0; 
        }
        internal Ball(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r; 
            this.stepy = 1;
            this.stepx = 1;
        }
        internal int x;
        internal int y;
        internal int stepx;
        internal int stepy;
        internal int r; 
        internal void checkBoard()
        {
                if (x + r >= cx)
                {
                    stepx *= -1;
                    x = cx - r;
                }
                if (y + r >= cy)
                {
                    stepy *= -1;
                    y = cy - r;
                }
                if (x - r <= 0)
                {
                    stepx *= -1;
                    x = r;
                }
                if (y - r <= 0)
                {
                    stepy *= -1;
                    y =r;
                }
        }
        internal void paint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            x += stepx;
            y += stepy;
            checkBoard();
        }

    }


    class Program
    {


        static int numStars()
        {
            Console.WriteLine("How many balls do you prefer?");
            int num;
            bool ques = Int32.TryParse(Console.ReadLine(), out num);
            if (ques == false || num == 0)
                throw new ArgumentException("Non valid data");
            return num;
        }

        static Ball[] createArr(int quantity)
        {
            Random r = new Random();
            Ball[] balls = new Ball[quantity];
            for (int i = 0; i < balls.Length; i++)
            {
                balls[i] = new Ball(r.Next(0, Ball.cx), r.Next(0, Ball.cy), 0);

            }
            return balls; 
        }


        static void checkPos(ref Ball[] balls)
        {
            for (int i = 0; i < balls.Length; i++)
                for( int j = i + 1; j < balls.Length; j++)
                {
                    if ((balls[i].x + balls[i].r + 1 == balls[j].x - balls[j].r || balls[i].x - balls[i].r  == balls[j].x + balls[j].r + 1 || balls[i].x + balls[i].r == balls[j].x + balls[j].r) 
                        && balls[i].y == balls[j].y)
                    {
                        balls[i].stepx *= -1;
                        balls[j].stepx *= -1;
                        balls[i].stepy *= -1;
                    }
                    if ((balls[i].y - balls[i].r == balls[j].y + balls[j].r + 1 || balls[i].y - balls[i].r == balls[j].y + balls[j].r + 1 || balls[i].y + balls[i].r == balls[j].y + balls[j].r) 
                        && balls[i].x == balls[j].x)
                    {
                        balls[i].y = balls[j].y;
                        balls[i].stepy *= -1;
                        balls[j].stepy *= -1;
                        balls[j].stepx *= -1;
                    }
                }
        }

        static void paint(ref Ball[] balls)
        {
            while (true)
            {
                Console.CursorVisible = false;
                for (int i = 0; i < balls.Length; i++)
                    balls[i].paint();
                checkPos(ref balls);
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
            Ball[] balls = createArr(quantity);
            paint(ref balls);
        }
    }
}
