using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
{

    class Collection
    {

        Link anchor;
        

        public Collection()
        {
            anchor = new Link(0);
        }
        

        public void Add(int number)
        {
            Link last = null ;


            last.next = new Link(number);
        }


        

        public int Get(int index)
        {
            return 0;
        }
        //a e y z a m m
        public void Remove(int index)
        {
            
        }

        public int Size()
        {
            return 0;
        }

        public int[] ToArray()
        {
            int[] temp = null;
            
            return temp;
        }

        public int IndexOf(int number)
        {
            return 0;
        }



        //a b c d 0
        public void Insert(int number, int index)
        {
            
        }

        public void Set(int number, int index)
        {

        }

        public bool Equals(Collection other)
        {
            
            return true;
        }

        class Link
        {
            public int value;
            public Link next;

            public Link(int value)
            {
                this.value = value;
                this.next = null;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
