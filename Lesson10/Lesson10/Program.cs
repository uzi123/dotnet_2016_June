using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Canvas
    {
        bool[,] canvas;

        public Canvas()
        {
            canvas = new bool[25, 50];
        }

        public void DrawRectangle(int x, int y, int width, int height)
        {
            //TODO: check parameters

            for (int i = 0; i < height; i++)
            {
                canvas[y + i + 1, x] = true;
                canvas[y + i + 1, x + width - 1] = true;
            }
            for (int i = 1; i < width; i++)
            {
                canvas[y + 1, x + i] = true;
                canvas[y + height, x + i] = true;
            }
        }

        public void Print()
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i,j] ? "*" : " ");
                }
                Console.WriteLine();

            }
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.DrawRectangle(10, 1, 8, 10);
            canvas.DrawRectangle(6, 4, 8, 10);
            canvas.Print();
        }
    }
}
