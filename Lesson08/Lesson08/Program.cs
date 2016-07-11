using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class BinaryTree
    {
        Vertex anchor;

        public BinaryTree()
        {
            anchor = new Vertex(0);
        }

        public int getMax()
        {

        }

        class Vertex
        {
            public int value;
            public Vertex left;
            public Vertex right;

            public Vertex(int value)
            {
                this.value = value;
            }
        }
    }
}
