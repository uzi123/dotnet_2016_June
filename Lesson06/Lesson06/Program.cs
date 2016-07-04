using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    class Collection
    {
        int[] nums;
        int pos;

        public Collection()
        {
            nums = new int[10];
            pos = 0;
        }

        public void Add(int number)
        {
            if(pos == nums.Length)//no room!
            {
                int[] temp = new int[nums.Length * 2];
                for (int i = 0; i < nums.Length; i++)
                {
                    temp[i] = nums[i];
                }
                nums = temp;
            }
            nums[pos++] = number;
        }

        public int Get(int index)
        {

            return 0;
        }

        public void Remove(int index)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
