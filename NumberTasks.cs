using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTaskSolve
{
    internal class NumberTasks
    {
        internal int EnterNumber()
        {
            Console.WriteLine("Ededi daxil edin:");
            int n=int.Parse(Console.ReadLine());

            return  n;
        }
        internal int GetReverseNumber(int number)
        {
            int reverseNumber = 0;
            int n = (int)Math.Log10(number);
            int r;

            while(n!=0)
            {
                r = number % 10;
                reverseNumber += r * (int)Math.Pow(10, n--);
                number /= 10;

            }

            return reverseNumber;


        }
    }
}

