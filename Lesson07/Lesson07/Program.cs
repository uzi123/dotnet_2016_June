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
            Link last = anchor ;
            while (last.next != null)
                last = last.next;
            last.next = new Link(number);
        }


        

        public int Get(int index)
        {
            int counter = -1;
            Link link = anchor;
            while(link.next != null && counter < index)
            {
                link = link.next;
                counter++;
            }
            if (counter == index)
                return link.value;
            else
                throw new Exception("index out of bounds!");
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

        class A
        {
            public int x;
            public B b;
        }

        class B
        {
            public int x;
            public A a;
        }

        static void Main(string[] args)
        {
            /*
            A a = new A();
            a.x = 3;
            B b = new B();
            b.x = 8;
            a.b = new B();
            b.a = a;
            a.b.x = 19;
            Console.WriteLine(b.x);
            */
            Collection col = new Collection();
            col.Add(2);
            col.Add(22);
            col.Add(234);

            Console.WriteLine(col.Get(3));
        }
    }
}
