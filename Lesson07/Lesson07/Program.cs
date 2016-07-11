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
        Link last;
        int count;

        public Collection()
        {
            anchor = new Link(0);
            last = anchor;
            count = 0;
        }
        

        public void Add(int number)
        {
            /*
            Link last = anchor ;
            while (last.next != null)
                last = last.next;
            last.next = new Link(number);
            */
            last.next = new Link(number);
            last = last.next;
            count++;
        }


        

        public int Get(int index)
        {
            if (index >= count || index < 0)
                throw new Exception("index out of bounds");
            int counter = -1;
            Link link = anchor;
            while(counter < index)
            {
                link = link.next;
                counter++;
            }
            return link.value;
        }
        //a e y z a m m
        public void Remove(int index)
        {
            if (index >= count || index < 0)
                throw new Exception("index out of bounds");
            Link theOneBefore = anchor;
            for (int i = 0; i < index; i++)
                theOneBefore = theOneBefore.next;
            if(index == count - 1)
            {
                last = theOneBefore;
            }
            theOneBefore.next = theOneBefore.next.next;
            count--;
        }

        public int Size()
        {
            return count;
        }

        public int[] ToArray()
        {
            int[] temp = new int[count];
            Link link = anchor;
            for (int i = 0; i < count; i++)
            {
                link = link.next;
                temp[i] = link.value;
            }
            return temp;
        }

        public int IndexOf(int number)
        {
            int index = -1;
            Link link = anchor;
            while(link.next != null)
            {
                link = link.next;
                index++;
                if (link.value == number)
                    return index;
            }
            return -1;
        }



        //a b c d 0
        public void Insert(int number, int index)
        {
            if (index == count - 1)
            {
                Add(number);
                return;
            }
            if (index >= count || index < 0)
                throw new Exception("index out of bounds");
            Link theOneBefore = anchor;
            for (int i = 0; i < index; i++)
                theOneBefore = theOneBefore.next;
            Link insertedLink = new Link(number);
            insertedLink.next = theOneBefore.next;
            theOneBefore.next = insertedLink;
            count++;
        }

        public void Set(int number, int index)
        {
            if (index >= count || index < 0)
                throw new Exception("index out of bounds");
            Link link = anchor;
            for (int i = 0; i < index + 1; i++)
                link = link.next;
            link.value = number;
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
