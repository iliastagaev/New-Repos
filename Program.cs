using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace prime
{
    


    class Program
    {
        public static bool IsPrime(int a)
        {
            bool ispr = true;
            if (a == 1)
            {
                ispr = false;
            }
            if (a == 2)
            {
                ispr = true;
            }
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0)
                {
                    ispr = false;
                    break;
                }
            }
            return ispr;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
            int n = values.Length;
            for (int i = 0; i < n; ++i)
            {
                if (IsPrime(int.Parse(values[i])))
                {
                    Console.Write(values[i] + ' ');
                }
            }
            Console.ReadKey();
        }

}
}