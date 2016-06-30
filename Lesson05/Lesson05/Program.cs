using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{

    class DivisionResult
    {
        public int quotient;
        public int remainder;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DivisionResult result = division(7, 3);
            Console.WriteLine("3 fits in 7 " + result.quotient
                +" times, with a remainder of " +
                result.remainder);
            
        }

        static int distance(int x, int y)
        {
            int small = x;
            int large = y;
            if (x > y)
            {
                small = y;
                large = x;
            }
            int result = 0;
            while (small + result < large)
                result++;
            return result;
        }

        static int product(int x, int y)
        {
            int small = x;
            int large = y;
            if (x > y)
            {
                small = y;
                large = x;
            }
            int result = 0;
            for(int i = 0; i < small; i++)
                result += large;
            return result;
        }
        static int quotient(int x, int y)
        {
            if (y == 0)
                return -1;
            int result = 0;
            int sum = y;
            while(sum <= x)
            {
                result++;
                sum += y;
            }
            return result;
        }

        static int remainder(int x, int y)
        {
            if (y == 0)
                return -1;
            return distance(x, product(quotient(x, y), y));
        }

        static DivisionResult division(int x, int y)
        {
            if (y == 0)
            {
                /*
                DivisionResult error = new DivisionResult();
                error.quotient = -1;
                return error;
                */
                return null;
            }
            int result = 0;
            int sum = y;
            int temp = 0;
            while (sum <= x)
            {
                result++;
                sum += y;
                temp += y;
            }
            DivisionResult divisionResult = new DivisionResult();
            divisionResult.quotient = result;
            divisionResult.remainder = distance(x, temp);

            return divisionResult;
        }
    }
}
