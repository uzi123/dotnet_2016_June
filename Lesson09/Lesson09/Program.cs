using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node3.right = node5;

            Console.WriteLine(node1.GetSum());
            */
            DrawRectangle(5, 3, 30, 10);
            DrawRectangle(2, 7, 30, 10);
            //DrawX(26);
        }

        public static void DrawRectangle(int x, int y, int width, int height)
        {
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < width; j++)
                {
                    bool isFrame = i == 0 || i == height - 1 || j == 0 || j == width - 1;
                    Console.Write(isFrame ? "*" : " ");
                }
                Console.WriteLine();
            }
            
        }

        public static void DrawX(int size)
        {
            if (size % 2 == 0)
                size--;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bool isDiagonal = i == j || i + j == size - 1;
                    Console.Write(isDiagonal ? "*" : " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Node
    {
        public int value;
        public Node left, right;


        public Node(int value)
        {
            this.value = value;
        }

        public int GetMax()
        {
            int max = value;
            if(right != null)
            {
                int maxRight = right.GetMax();
                if (maxRight > max)
                    max = maxRight;
            }
            if(left != null)
            {
                int maxLeft = left.GetMax();
                if (maxLeft > max)
                    max = maxLeft;
            }
            return max;

        }

        public int GetSum()
        {
            int sumRight = 0;
            int sumLeft = 0;
            if (right != null)
                sumRight = right.GetSum();
            if (left != null)
                sumLeft = left.GetSum();
            return sumLeft + sumRight + value;
        }
    }
}
